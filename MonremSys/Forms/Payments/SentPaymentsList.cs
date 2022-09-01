
using MonremSys.Forms.Payments;
using System;
using System.Windows.Forms;

namespace MonremSys
{
    public partial class SentPaymentsList : Form
    {


        //Child Forms
        PaymentManageForm form;
        DetailsForm details_form;
        ReceiptForm receipt_form;

        public SentPaymentsList()
        {
            InitializeComponent();

            form = new PaymentManageForm(/*this*/);
            details_form = new DetailsForm();
            receipt_form = new ReceiptForm();
        }
        //------------------------------On Form Load-------------------------------------

        private void SentPaymentsList_Load(object sender, EventArgs e)
        {
            UpdateListInfo();
        }

        //load data from Database
        public void UpdateListInfo(string query= "select id,amount,rate,currency,comission,value,description,payment_date from payment where type=0")
        {
            //Type:0 means I'm the one who approved money
            DbManager.DisplayAndSearch(query, sentpaymentsDgv);
            paymentsCountLbl.Text = sentpaymentsDgv.RowCount.ToString();
        }

        //------------------------------Form Management Cotrols-------------------------------------

        // Search Field Method
        private void SearchItem(object sender, EventArgs e)
        {
            string query = $"select id,amount,rate,currency,comission,value,description,payment_date from payment where description like '%{searchTxt.Text}%' and type=0;";
            UpdateListInfo(query);
        }


        //Add new payment button click
        private void NewItem(object sender, EventArgs e)
        {
            form.CurrencyBindingSource.DataSource = new Currency();

            form.PaymentBindingSource.DataSource = new Payment
            {
                Transfercurrency = form.CurrencyBindingSource.Current as Currency,
                Type=false,
                
            };
            form.ShowDialog();
        }

        private void EditItem(object sender, EventArgs e)
        {
            Payment SelectedPayment = (Payment)new Payment().RetrievefromDb(Convert.ToInt32(sentpaymentsDgv.SelectedRows[0].Cells[0].Value));
            form.PaymentBindingSource.DataSource = SelectedPayment;
            form.CurrencyBindingSource.DataSource = SelectedPayment.Transfercurrency;
            form.ShowDialog();
            UpdateListInfo();

        }

        private void DeleteItem(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(sentpaymentsDgv.SelectedRows[0].Cells[0].Value);

            if (confirmMessageDialog.Show("You want to delete selected item, Are you Sure ?", "Warning") == DialogResult.Yes)
            {
                Payment payment = (Payment)new Payment().RetrievefromDb(id);
                payment.DeletefromDb();
                //UpdateRemittancesCount();
                UpdateListInfo();
            }
            return;
        }

        //------------------------------Other Context Menu Options-------------------------------------
        private void ViewItemDetails(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(sentpaymentsDgv.SelectedRows[0].Cells[0].Value);
            Payment payment = (Payment)new Payment().RetrievefromDb(id);
            details_form.detailsBindingSource.DataSource = payment;
            details_form.ShowDialog();
        }

        private void settingsCM(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = sentpaymentsDgv.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    sentpaymentsDgv.Rows[hti.RowIndex].Selected = true;
                    settingsCMS.Show(sentpaymentsDgv, e.Location);
                }

            }
        }

        private void CopyPaymentData(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(sentpaymentsDgv.SelectedRows[0].Cells[0].Value);
            Payment payment = (Payment)new Payment().RetrievefromDb(id);
            Clipboard.SetText(payment.ToString());
        }

        private void GenerateReceipt(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(sentpaymentsDgv.SelectedRows[0].Cells[0].Value);
            Payment payment = (Payment)new Payment().RetrievefromDb(id);
            receipt_form.receiptImage = payment.GenReceipt("../../Data/PaymentTemplate2.jpg");
            receipt_form.receipt_data = payment.ToString();
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
                string query = $"select id,amount,rate,currency,comission,value,description,payment_date from payment where type=0 and payment_date BETWEEN '{from}' AND '{to}';"; 
            UpdateListInfo(query);
        }
    }
}
