using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MonremSys.Forms.Remittances
{
    public partial class ReceiptForm : Form
    {
        public Bitmap receiptImage;
        public string receipt_data;

        public ReceiptForm()
        {
            InitializeComponent();
           
        }
        //------------------------------------ On Form Load -------------------------------------
        private void ReceiptForm_Load(object sender, System.EventArgs e)
        {
            reciptPB.Image = receiptImage;
        }

        //------------------------------------ Form Controls -------------------------------------

        private void reciptPB_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                settingCMS.Show(reciptPB, e.Location);
            }
        }

        
       
        private void okBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        // Copy Remittance Data as Text
        private void copyBtn_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText(receipt_data);

        }
        // Copy Remittance Data as Image
        private void copyImageToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetDataObject(receiptImage);
        }


        // Save Receipt Image
        private void saveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
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

        private void PrintImage()
        {
            PrintDocument pd = new PrintDocument();
            pd.OriginAtMargins = true;
            pd.DefaultPageSettings.Landscape = true;
            pd.Print();
        }

        void print_manage(object sender, PrintPageEventArgs e)
        {
            double cmToUnits = 100 / 2.54;
            e.Graphics.DrawImage(receiptImage, 0, 0, (float)(30 * cmToUnits), (float)(20 * cmToUnits));
        }

        private void PrintReceipt(object sender, System.EventArgs e)
        {
            PrintDocument pd = new PrintDocument();

            pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            pd.OriginAtMargins = true;
            pd.DefaultPageSettings.Landscape = true;



            pd.PrintPage += new PrintPageEventHandler(print_manage);


            reciptPintReviewDialoge.Document = pd;
            reciptPintReviewDialoge.ShowDialog();

            pd.Print();

        }
    }
}
