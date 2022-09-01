using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonremSys.Forms.Payments
{
    public partial class ReceiptForm : Form
    {

        public Bitmap receiptImage;
        public string receipt_data;


        public ReceiptForm()
        {
            InitializeComponent();
        }
        // ----------------------------------- On Form Load ---------------------------------
        private void ReceiptForm_Load(object sender, System.EventArgs e)
        {
            reciptPB.Image = receiptImage;
        }

        private void reciptPB_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                settingCMS.Show(reciptPB, e.Location);
            }
        }

        private void CopyReciptImage(object sender, System.EventArgs e)
        {
            Clipboard.SetDataObject(receiptImage);
        }

        private void CopyReceiptText(object sender, System.EventArgs e)
        {
            Clipboard.SetText(receipt_data);

        }

        private void okBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void SaveReceiptImage(object sender, System.EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.jpg;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".png":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;

                }
                reciptPB.Image.Save(sfd.FileName, format);
            }
        }
    }
}
