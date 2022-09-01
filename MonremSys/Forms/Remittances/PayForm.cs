using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonremSys.Forms.Remittances
{
    public partial class PayForm : Form
    {

        string attachment_path;
        ReceivedRemittance Rmnc;

        ReceivedRemittancesList parent_form;
        public PayForm(ReceivedRemittancesList _parent)
        {
            InitializeComponent();
            parent_form = _parent;
        }
        // ----------------------------------- On Form Load --------------------------------
        private void PayForm_Load(object sender, EventArgs e)
        {

            Rmnc = PayBindingSource.Current as ReceivedRemittance;

            payInfoTxt.DataBindings.Clear();
            okBtn.DataBindings.Clear();
            pathTxt.DataBindings.Clear();
            attachmentPb.DataBindings.Clear();

            attachment_path = "";
            attachmentPb.Image = null;


            payInfoTxt.DataBindings.Add("Text", PayBindingSource, "PayInfo");
            pathTxt.DataBindings.Add("Text", PayBindingSource, "PayDocPath");
            okBtn.DataBindings.Add("Enabled", PayBindingSource, "IsPayValid");
            attachmentPb.DataBindings.Add("ImageLocation", PayBindingSource, "PayDocPath");

            // If remittance is paid then view payment data
            if (Rmnc.Ispaid)
            {
                okBtn.Enabled = attachBtn.Enabled = payInfoTxt.Enabled = pathTxt.Enabled = false;
                Formtitle.Text = "Paying Details";
            }
            // or pay 
            else
            {
                okBtn.Enabled = attachBtn.Enabled = payInfoTxt.Enabled = pathTxt.Enabled = true;
                Formtitle.Text = "Pay a Remittance";
            }
        }

        private void PayRemittance(object sender, EventArgs e)
        {
            if (warningdialoge.Show("Paying Remittance Makes Unable to Edit,RePay,Delete this Remittace") == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(attachment_path))
                {
                    Rmnc.PayDocPath = Media.UploadFile(attachment_path, Rmnc);
                }

                Rmnc.Pay();
                Rmnc.EditinDb();
                parent_form.UpdateListInfo();
                this.Close();
            }
            
        }

        private void UploadAttachment(object sender, EventArgs e)
        {
            if (attachDialog.ShowDialog() == DialogResult.OK)
            {
                attachment_path = attachDialog.FileName;
                pathTxt.Text = attachDialog.FileName;
                attachmentPb.Image = new Bitmap(attachDialog.FileName);
                
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }


    }

   
}
