using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MonremSys.Forms.Remittances
{
    public partial class SentRemManageForm : Form
    {

        //Sent Remittances List Form
        private readonly SentRemittancesList parent_form;


        public SentRemManageForm(SentRemittancesList _parent)
        {
            InitializeComponent();

            parent_form = _parent;
        }



        //------------------------- TileBar Handling ------------------------------
        //Handling Gripping of Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void formTile_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //Close Form
        private void closeBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        // --------------------------------- on Form Load -----------------------


        private void SentRemManageForm_Load(object sender, EventArgs e)
        {
            // Initiaize Auto Complete Sources
            receiverTxt.AutoCompleteCustomSource = DbManager.GetSuggestionCollection("customer", "full_name");
            senderTxt.AutoCompleteCustomSource = DbManager.GetSuggestionCollection("customer", "full_name");
            receiver_phTxt.AutoCompleteCustomSource = DbManager.GetSuggestionCollection("customer", "phone_number");
            sender_phTxt.AutoCompleteCustomSource = DbManager.GetSuggestionCollection("customer", "phone_number");
            destinationTxt.AutoCompleteCustomSource = DbManager.GetSuggestionCollection("destination", "name");
            //destinationTxt.AutoCompleteCustomSource = DbManager.GetSuggestionCollection("destination", "name");
            BindControl();
            // Initialize graphical info
            var id = ((SentRemittance)SentRemBindingSource.Current).Id;
            if (id != 0)
            {
                formTitle.Text = "Update Existing Remittance";
                saveBtn.Text = "Update";
                destinationTxt.Enabled = amountNum.Enabled = currencyCombo.Enabled = rateNum.Enabled = commissionNum.Enabled = false;
            }
            else
            {
                destinationTxt.Enabled = amountNum.Enabled = currencyCombo.Enabled = rateNum.Enabled = commissionNum.Enabled = true;
                formTitle.Text = "Send New Remittance";
                saveBtn.Text = "Save";
            }
            rateNum.Enabled = false;

        }

        private void BindControl()
        {
            // Clear old bindings
            destinationTxt.DataBindings.Clear();
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
            destinationTxt.DataBindings.Add("Text", SentRemBindingSource, "Destination", true);

            receiverTxt.DataBindings.Add("Text", ReceiverBindingSource, "Name", true);
            receiver_phTxt.DataBindings.Add("Text", ReceiverBindingSource, "Phone_number", true);

            senderTxt.DataBindings.Add("Text", SenderBindingSource, "Name", true);
            sender_phTxt.DataBindings.Add("Text", SenderBindingSource, "Phone_number", true);

            amountNum.DataBindings.Add("Value", SentRemBindingSource, "Amount", true);

            currencyCombo.DataBindings.Add("SelectedIndex", CurrencyBindingSource, "Cindex",true);
            rateNum.DataBindings.Add("Value", CurrencyBindingSource, "Rate",true);

            commissionNum.DataBindings.Add("Value", SentRemBindingSource, "Comission", true);
            descriptionTxt.DataBindings.Add("Text", SentRemBindingSource, "Description", true);

            saveBtn.DataBindings.Add("Enabled", SentRemBindingSource, "IsValid", true);

        }

        //------------------------- Form Control Buttons Handling ------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            destinationTxt.Focus();
            this.Close();
            parent_form.UpdateListInfo();
        }

        private void Save()
        {
            SentRemittance Rmnc = (SentRemittance)SentRemBindingSource.Current;


            if (Rmnc != null && Rmnc.IsValid)
            {
                if (Rmnc.Id == 0)
                {
                    if(Rmnc.Amount > int.Parse(Settings1.Default.SafetyLevel))
                    {
                        if (confrimBox.Show($"Amount of this remittance is greater than {Settings1.Default.SafetyLevel} , Are you Sure ?", "Warning") == DialogResult.OK)
                        {
                            System.Console.WriteLine("code reached");
                            Rmnc.AddintoDb();
                        }
                       
                    }
                    else
                        Rmnc.AddintoDb();

                }
                else
                    Rmnc.EditinDb();
            }
            else if(Rmnc.Sender.Equals(Rmnc.Receiver))
            {
                MessageBox.Show("Sender and Receiver can't be the same", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FreezeRateonUSD(object sender, EventArgs e)
        {
            if (currencyCombo.SelectedIndex == 0)
                rateNum.Enabled = false;
            else
                rateNum.Enabled = true;
        }

    }
}
