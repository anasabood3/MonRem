using MonremSys.Forms.Customers;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MonremSys
{
    public partial class CustomersList : Form
    {
        
        //Child Forms 
        CustomerManage manage_form;
        DetailsForm details_form;


        public CustomersList()
        {
            InitializeComponent();
            manage_form = new CustomerManage(this);
            details_form = new DetailsForm();
        }


        // --------------------------------On Form Load----------------------------
        private void CustomerList_Load(object sender, EventArgs e)
        {
            UpeateListInfo();
        }
        //load data from Database
        public void UpeateListInfo(string query= "select * from customer")
        {
            DbManager.DisplayAndSearch(query, sentRemsDgv);
            customersNoLbl.Text = sentRemsDgv.RowCount.ToString();
        }

        // --------------------------------Items Management----------------------------

        // Search Field Method
        private void SearchItem(object sender, EventArgs e)
        {
            // SQL Injection Warning
            string query = $"select * from customer where full_name like '%{searchTxt.Text}%' or phone_number like '%{searchTxt.Text}%' or address like '%{searchTxt.Text}%'";
            UpeateListInfo(query);
      
        }


        //Add new customer button click
        private void AddCustomer(object sender, EventArgs e)
        {
            manage_form.customerBindingSource.DataSource = new Customer();
            manage_form.ShowDialog();
        }

        private void EditItem(object sender, EventArgs e)
        {
            manage_form.customerBindingSource.DataSource = new Customer().RetrievefromDb(Convert.ToInt32(sentRemsDgv.SelectedRows[0].Cells[1].Value));
            manage_form.ShowDialog();
            UpeateListInfo();
            return;
        }


        private void DeleteItem(object sender, EventArgs e)
        {

            if (confirmMessageDialog.Show("Are You Sure Amego ...??","Warning") == DialogResult.Yes)
            {
                Customer csr = new Customer
                {
                    Id = Convert.ToInt32(sentRemsDgv.SelectedRows[0].Cells[1].Value),
                    Name = sentRemsDgv.SelectedRows[0].Cells[2].Value.ToString(),
                    Phone_number = sentRemsDgv.SelectedRows[0].Cells[3].Value.ToString(),
                    Address = sentRemsDgv.SelectedRows[0].Cells[4].Value.ToString(),
                };
                csr.DeletefromDb();
                UpeateListInfo();
            }
            
            return;
        }
        // --------------------------------Settings Context Menu---------------------------
        private void ViewSettingsCM(object sender, MouseEventArgs e)
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
            var id = Convert.ToInt32(sentRemsDgv.SelectedRows[0].Cells[1].Value);
            details_form.detailsBindingSource.DataSource = new Customer().RetrievefromDb(id);
            details_form.ShowDialog();
        }

        private void CopyRemittanceData(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(sentRemsDgv.SelectedRows[0].Cells[1].Value);
            Customer Rmnc = new Customer().RetrievefromDb(id);
            Clipboard.SetText(Rmnc.ToString().Trim());
        }
    }
}
/*
 1- Printing funtcionality
 2- 
 */