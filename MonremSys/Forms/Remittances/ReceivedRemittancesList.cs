using MonremSys.Forms.Remittances;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MonremSys
{
    public partial class ReceivedRemittancesList : Form
    {

        //Child Forms
        ReceivedRemManageForm form;
        PayForm pay_form;
        DetailsForm details_form;


        public ReceivedRemittancesList()
        {
            InitializeComponent();

            form = new ReceivedRemManageForm(this);
            details_form = new DetailsForm();
            pay_form = new PayForm(this);
        }




        //----------------------------On Form Load--------------------------------------

        private void ReceivedRemList_Load(object sender, EventArgs e)
        {
            UpdateListInfo();
        }

        //load data from Database
        public void UpdateListInfo(string qurey = @"select S.id,C1.full_name,C1.phone_number,C2.full_name,C2.phone_number,S.amount,S.rate,S.currency,S.comission,S.value,S.description,S.created_at,is_paid,paid_at
                            from received_remittance as S left join customer as C1 on S.receiver = C1.id
                             left join customer as C2 on S.sender = C2.id;")
        {
            
            DbManager.DisplayAndSearch(qurey, receivedRemsDgv);
            remittancesNoLbl.Text = receivedRemsDgv.RowCount.ToString();
        }

        //----------------------------Form Controls--------------------------------------

        // Search Field Method
        // Warning ⚠⚠⚠⚠ Sql Injection
        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            string query = $@"select S.id,C1.full_name,C1.phone_number,C2.full_name,C2.phone_number,S.amount,S.rate,S.currency,S.comission,S.value,S.description,S.created_at,is_paid,paid_at
                            from received_remittance as S left join customer as C1 on S.receiver = C1.id
                             left join customer as C2 on S.sender = C2.id where C1.full_name like '%{searchTxt.Text}%' or C2.full_name like '%{searchTxt.Text}%' ;";

            UpdateListInfo(query);
        }


        //Add new received remittance
        private void NewItem(object sender, EventArgs e)
        {
            form.SenderBindingSource.DataSource = new Customer();
            form.ReceiverBindingSource.DataSource = new Customer();
            form.CurrencyBindingSource.DataSource = new Currency();

            form.ReceivedRemBindingSource.DataSource = new ReceivedRemittance
            {
                Receiver = form.ReceiverBindingSource.Current as Customer,
                Sender = form.SenderBindingSource.Current as Customer,
                Transfercurrency = form.CurrencyBindingSource.Current as Currency,
            };
            UpdateListInfo();
            form.ShowDialog();
        }


        private void EditItem(object sender, EventArgs e)
        {
            ReceivedRemittance SelectedRmnc = (ReceivedRemittance)new ReceivedRemittance().RetrievefromDb(Convert.ToInt32(receivedRemsDgv.SelectedRows[0].Cells[0].Value));
            form.ReceivedRemBindingSource.DataSource = SelectedRmnc;
            form.SenderBindingSource.DataSource = SelectedRmnc.Sender;
            form.ReceiverBindingSource.DataSource = SelectedRmnc.Receiver;
            form.CurrencyBindingSource.DataSource = SelectedRmnc.Transfercurrency;
            form.ShowDialog();
        }

        private void DeleteItem(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(receivedRemsDgv.SelectedRows[0].Cells[0].Value);

            if (confirmMessageDialog.Show("You want to delete selected item, Are you Sure ?", "Information") == DialogResult.Yes)
            {
                ReceivedRemittance Rmnc = (ReceivedRemittance)new ReceivedRemittance().RetrievefromDb(id);
                Rmnc.DeletefromDb();
                UpdateListInfo();
            }
            return;
        }
        //----------------------------Other context menu options--------------------------------------
        private void ViewItemDetails(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(receivedRemsDgv.SelectedRows[0].Cells[0].Value);
            details_form.detailsBindingSource.DataSource = new ReceivedRemittance().RetrievefromDb(id);
            details_form.ShowDialog();
        }

        private void ViewSettingsContextMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = receivedRemsDgv.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    receivedRemsDgv.Rows[hti.RowIndex].Selected = true;
                    var id = Convert.ToInt32(receivedRemsDgv.SelectedRows[0].Cells[0].Value);
                    ReceivedRemittance Rmnc = (ReceivedRemittance)new ReceivedRemittance().RetrievefromDb(id);
                    
                    if (Rmnc.Ispaid)
                    {
                        //Disable Edit, Delete, Repay
                        edit.Visible = delete.Visible = pay.Visible = false;
                        viewRemittanceData.Visible = true;
                    }
                    else
                    {
                        edit.Visible = delete.Visible = pay.Visible = true;
                        viewRemittanceData.Visible = false;
                    }
                        settingsCMS.Show(receivedRemsDgv, e.Location);
                }

            }
        }

        private void CopyRemittanceData(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(receivedRemsDgv.SelectedRows[0].Cells[0].Value);
            ReceivedRemittance Rmnc = (ReceivedRemittance)new ReceivedRemittance().RetrievefromDb(id);
            Clipboard.SetText(Rmnc.ToString("short"));
        }

        private void PayRemittance(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(receivedRemsDgv.SelectedRows[0].Cells[0].Value);
            pay_form.PayBindingSource.DataSource = new ReceivedRemittance().RetrievefromDb(id);
            pay_form.ShowDialog();
        }

        private void ViewRemittancePaymentData(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(receivedRemsDgv.SelectedRows[0].Cells[0].Value);
            pay_form.PayBindingSource.DataSource = new ReceivedRemittance().RetrievefromDb(id);
            pay_form.ShowDialog();
        }


        private void FilterList(object sender, EventArgs e)
        {
            var filter_index = viewFilterCombo.SelectedIndex;
            string from = DbManager.history[filter_index];
            string to = DateTime.Today.AddDays(+1).ToString("yyyy-MM-dd");
            if (filter_index == 1)
            {
                to = DbManager.history[0];
            }
            string query = $@"select S.id,C1.full_name,C1.phone_number,C2.full_name,C2.phone_number,S.amount,S.rate,S.currency,S.comission,S.value,S.description,S.created_at,is_paid,paid_at
                            from received_remittance as S left join customer as C1 on S.receiver = C1.id
                             left join customer as C2 on S.sender = C2.id WHERE created_at BETWEEN '{from}' AND '{to}';";
            UpdateListInfo(query);
        }
    }
}
