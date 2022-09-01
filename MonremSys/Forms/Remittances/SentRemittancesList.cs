using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using DGVPrinterHelper;
namespace MonremSys.Forms.Remittances
{
    public partial class SentRemittancesList : Form
    {

        //Child Forms

        SentRemManageForm manage_form;
        ReceiptForm receipt_form;
        DetailsForm details_form;


        public SentRemittancesList()
        {
            InitializeComponent();


            manage_form = new SentRemManageForm(this);
            details_form = new DetailsForm();
            receipt_form = new ReceiptForm();

        }

        // ----------------------------------------------- On form Load--------------------------------

        private void SentRemittancesList_Load(object sender, EventArgs e)
        {
            string query = $@"select S.id,C1.full_name,C1.phone_number,C2.full_name,C2.phone_number,S.amount,S.rate,S.currency,S.destination,S.comission,S.value,S.destination,S.description,S.created_at
                            from sent_remittance as S left join customer as C1 on S.receiver = C1.id
                             left join customer as C2 on S.sender = C2.id WHERE created_at BETWEEN '{DbManager.history[0]}' AND '{DateTime.Today.AddDays(+1).ToString("yyyy-MM-dd")}' ;";
            UpdateListInfo();
            
        }


        //load data from Database
        public void UpdateListInfo(string qurey = @"select S.id,C1.full_name,C1.phone_number,C2.full_name,C2.phone_number,S.amount,S.rate,S.currency,S.destination,S.comission,S.value,S.destination,S.description,S.created_at
                            from sent_remittance as S left join customer as C1 on S.receiver = C1.id
                             left join customer as C2 on S.sender = C2.id;")
        {

            
            DbManager.DisplayAndSearch(qurey, sentRemsDgv);

            /////// Must be redesigned ////////
            for (int i = 0; i < sentRemsDgv.Rows.Count; i++)
            {
                ////Use when column names known
                int value = Convert.ToInt16(sentRemsDgv.Rows[i].Cells["currency"].Value);
                ////Use when column index known
                sentRemsDgv.Rows[i].Cells["currencyName"].Value = (CurrencyName)value;

            }

            remittancesNoLbl.Text = sentRemsDgv.RowCount.ToString();



        }

        // ----------------------------------------------- Form Controls--------------------------------

        // Search Field Method
        // Warning ⚠⚠⚠⚠ Sql Injection
        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            string query = $@"select S.id,C1.full_name,C1.phone_number,C2.full_name,C2.phone_number,S.amount,S.rate,S.currency,S.comission,S.value,S.destination,S.description,S.created_at
                            from sent_remittance as S left join customer as C1 on S.receiver = C1.id
                             left join customer as C2 on S.sender = C2.id where C1.full_name like '%{searchTxt.Text}%' or C2.full_name like '%{searchTxt.Text}%' ;";

            UpdateListInfo(query);
        }

        //Add new payment button click
        private void NewItem(object sender, EventArgs e)
        {


            manage_form.SenderBindingSource.DataSource = new Customer();
            manage_form.ReceiverBindingSource.DataSource = new Customer();
            manage_form.CurrencyBindingSource.DataSource = new Currency();

            manage_form.SentRemBindingSource.DataSource = new SentRemittance
            {
                Receiver = manage_form.ReceiverBindingSource.Current as Customer,
                Sender = manage_form.SenderBindingSource.Current as Customer,
                Transfercurrency = manage_form.CurrencyBindingSource.Current as Currency,
            };

            manage_form.ShowDialog();
        }

        private void EditItem(object sender, EventArgs e)
        {
            SentRemittance SelectedRmnc = (SentRemittance)new SentRemittance().RetrievefromDb(Convert.ToInt32(sentRemsDgv.SelectedRows[0].Cells["id"].Value));
            manage_form.SentRemBindingSource.DataSource = SelectedRmnc;
            manage_form.SenderBindingSource.DataSource = SelectedRmnc.Sender;
            manage_form.ReceiverBindingSource.DataSource = SelectedRmnc.Receiver;
            manage_form.CurrencyBindingSource.DataSource = SelectedRmnc.Transfercurrency;
            UpdateListInfo();
            manage_form.ShowDialog();

        }

        private void DeleteItem(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(sentRemsDgv.SelectedRows[0].Cells["id"].Value);

            if (confirmMessageDialog.Show("You want to delete selected item, Are you Sure ?", "Information") == DialogResult.Yes)
            {
                SentRemittance Rmnc = (SentRemittance)new SentRemittance().RetrievefromDb(id);
                Rmnc.DeletefromDb();
                UpdateListInfo();
            }
            return;
        }




        // ----------------------------------------------- Context Menu Other Options--------------------------------


        private void ViewSettingCM(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = sentRemsDgv.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    sentRemsDgv.Rows[hti.RowIndex].Selected = true;
                    settingsCMS.Show(sentRemsDgv, e.Location);
                }

            }
        }

        private void ViewItemDetails(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(sentRemsDgv.SelectedRows[0].Cells["id"].Value);
            details_form.detailsBindingSource.DataSource = new SentRemittance().RetrievefromDb(id);
            details_form.ShowDialog();
        }


        private void CopyRemittanceData(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(sentRemsDgv.SelectedRows[0].Cells["id"].Value);
            SentRemittance Rmnc = (SentRemittance)new SentRemittance().RetrievefromDb(id);            
            Clipboard.SetText(Rmnc.ToString("short").Trim());
        }

        private void GenerateReceipt(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(sentRemsDgv.SelectedRows[0].Cells["id"].Value);
            SentRemittance Rmnc = (SentRemittance)new SentRemittance().RetrievefromDb(id);
            receipt_form.receiptImage = Rmnc.GenReceipt("../../Data/SentRemTemplate2.jpg");
            receipt_form.receipt_data = Rmnc.ToString("receipt");
            receipt_form.ShowDialog();
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
            string query = $@"select S.id,C1.full_name,C1.phone_number,C2.full_name,C2.phone_number,S.amount,S.rate,S.currency,S.comission,S.value,S.destination,S.description,S.created_at
                            from sent_remittance as S left join customer as C1 on S.receiver = C1.id
                             left join customer as C2 on S.sender = C2.id WHERE created_at BETWEEN '{from}' AND '{to}';";
            UpdateListInfo(query);
        }

        private void PrintDGV(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Sender Remittances";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "Hector";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(sentRemsDgv);

        }
    }
}
