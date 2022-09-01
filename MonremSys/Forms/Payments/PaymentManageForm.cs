using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonremSys.Forms.Payments
{
    public partial class PaymentManageForm : Form
    {
        //SentPaymentsList parent_form;
        public PaymentManageForm()
        {
            InitializeComponent();
        }




        // --------------------------------- on Form Load -----------------------

        private void OnForm_Load(object sender, EventArgs e)
        {
            BindControl();
            // Initialize graphical info
            var id = ((Payment)PaymentBindingSource.Current).Id;
            if (id != 0)
            {
                formTitle.Text = "Update Existing Approval";
                saveBtn.Text = "Update";
                amountNum.Enabled = currencyCombo.Enabled = rateNum.Enabled = commissionNum.Enabled = false;
            }
            else
            {
                amountNum.Enabled = currencyCombo.Enabled = rateNum.Enabled = commissionNum.Enabled = true;
                formTitle.Text = "Add a New Approval";
                saveBtn.Text = "Save";
            }
        }

        private void BindControl()
        {
            // Clear old bindings

            amountNum.DataBindings.Clear();
            currencyCombo.DataBindings.Clear();
            rateNum.DataBindings.Clear();
            commissionNum.DataBindings.Clear();
            descriptionTxt.DataBindings.Clear();
            saveBtn.DataBindings.Clear();



            // Set new Data Bindings

            amountNum.DataBindings.Add("Value", PaymentBindingSource, "Amount", true);

            currencyCombo.DataBindings.Add("SelectedIndex", CurrencyBindingSource, "Cindex", true);
            rateNum.DataBindings.Add("Value", CurrencyBindingSource, "Rate", true);

            commissionNum.DataBindings.Add("Value", PaymentBindingSource, "Comission", true);
            descriptionTxt.DataBindings.Add("Text", PaymentBindingSource, "Description", true);

            saveBtn.DataBindings.Add("Enabled", PaymentBindingSource, "IsValid", true);

        }

        //------------------------- Form Control Buttons Handling ------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            descriptionTxt.Focus();
            this.Close();
        }

        private void Save()
        {
            Payment payment = (Payment)PaymentBindingSource.Current;


            if (payment != null && payment.IsValid)
            {
                if (payment.Id == 0)
                {
                    payment.AddintoDb();
                }
                else
                    payment.EditinDb();
            }
            else
            {
                MessageBox.Show("Validation Erorr", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cancel Form
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
