using System;
using System.Windows.Forms;

namespace MonremSys.Forms.Customers
{
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        // --------------------------------On Form Load---------------------------
        private void DetailsForm_Load(object sender, EventArgs e)
        {
            detailsLV.Items.Clear();
            Customer csr = detailsBindingSource.Current as Customer;
            foreach (var detail in csr.ToString().Split('\n'))
            {
                detailsLV.Items.Add(new ListViewItem(detail.Split(':')));
            }
        }


        // --------------------------------Form Controls---------------------------
        private void Ok(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyFullDetails(object sender, EventArgs e)
        {
            Customer csr = detailsBindingSource.Current as Customer;
            Clipboard.SetText(csr.ToString());
        }
    }
}
