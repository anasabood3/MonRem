using System;
using System.Windows.Forms;

namespace MonremSys.Forms.Remittances
{
    public partial class ReceivedRemManageForm : Form
    {

        //Received Remittances List Form
        private readonly ReceivedRemittancesList parent_form;


        public ReceivedRemManageForm(ReceivedRemittancesList _parent)
        {
            InitializeComponent();

            parent_form = _parent;
        }


        // --------------------------------- on Form Load -----------------------


        private void ReceivedRemManageForm_Load(object sender, EventArgs e)
        {
            // Initiaize Auto Complete Sources
            receiverTxt.AutoCompleteCustomSource = DbManager.GetSuggestionCollection("customer", "full_name");
            senderTxt.AutoCompleteCustomSource = DbManager.GetSuggestionCollection("customer", "full_name");
            receiver_phTxt.AutoCompleteCustomSource = DbManager.GetSuggestionCollection("customer", "phone_number");
            sender_phTxt.AutoCompleteCustomSource = DbManager.GetSuggestionCollection("customer", "phone_number");
            BindControl();
            // Initialize graphical info
            var id = ((ReceivedRemittance)ReceivedRemBindingSource.Current).Id;
            if (id != 0)
            {
                formTitle.Text = "Update Existing Remittance";
                saveBtn.Text = "Update";
                amountNum.Enabled = currencyCombo.Enabled = rateNum.Enabled = commissionNum.Enabled = false;
            }
            else
            {
                amountNum.Enabled = currencyCombo.Enabled = rateNum.Enabled = commissionNum.Enabled = true;
                formTitle.Text = "Add a New Received Remittance";
                saveBtn.Text = "Save";
            }
        }

        private void BindControl()
        {
            // Clear old bindings
            receiverTxt.DataBindings.Clear();
            receiver_phTxt.DataBindings.Clear();
            senderTxt.DataBindings.Clear();
            sender_phTxt.DataBindings.Clear();
            amountNum.DataBindings.Clear();
            currencyCombo.DataBindings.Clear();
            rateNum.DataBindings.Clear();
            commissionNum.DataBindings.Clear();
            descriptionTxt.DataBindings.Clear();
            saveBtn.DataBindings.Clear();



            // Set new Data Bindings

            receiverTxt.DataBindings.Add("Text", ReceiverBindingSource, "Name", true);
            receiver_phTxt.DataBindings.Add("Text", ReceiverBindingSource, "Phone_number", true);

            senderTxt.DataBindings.Add("Text", SenderBindingSource, "Name", true);
            sender_phTxt.DataBindings.Add("Text", SenderBindingSource, "Phone_number", true);

            amountNum.DataBindings.Add("Value", ReceivedRemBindingSource, "Amount", true);

            currencyCombo.DataBindings.Add("SelectedIndex", CurrencyBindingSource, "Cindex", true);
            rateNum.DataBindings.Add("Value", CurrencyBindingSource, "Rate", true);

            commissionNum.DataBindings.Add("Value", ReceivedRemBindingSource, "Comission", true);
            descriptionTxt.DataBindings.Add("Text", ReceivedRemBindingSource, "Description", true);

            saveBtn.DataBindings.Add("Enabled", ReceivedRemBindingSource, "IsValid", true);

        }

        //------------------------- Form Control Buttons Handling ------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            receiverTxt.Focus();
            this.Close();
            parent_form.UpdateListInfo();
        }

        private void Save()
        {
            ReceivedRemittance Rmnc = (ReceivedRemittance)ReceivedRemBindingSource.Current;


            if (Rmnc != null && Rmnc.IsValid)
            {
                // If remittance is new
                if (Rmnc.Id == 0)
                {
                    Rmnc.AddintoDb();
                }
                else
                    Rmnc.EditinDb();
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


        // -----------------------------------Form Validation------------------------------------

        private void PhoneNumberValidtion(object sender, KeyPressEventArgs e)
        {
            bool valid_input = char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || char.IsControl(e.KeyChar);
            if (!valid_input)
                e.Handled = true;
        }

    }
}
