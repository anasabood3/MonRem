using System;
using System.Windows.Forms;

namespace MonremSys.Forms.Payments
{
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }


        private void DetailsForm_Load(object sender, EventArgs e)
        {
            detailsLv.Items.Clear();
            Payment payment = detailsBindingSource.Current as Payment;

                foreach (var detail in (payment as Payment).ToString("full").Split('\n'))
                {
                    detailsLv.Items.Add(new ListViewItem(detail.Split('|')));
                }
        }

        private void CopyFullDetails(object sender, EventArgs e)
        {
            Payment payment = detailsBindingSource.Current as Payment;
            Clipboard.SetText(payment.ToString("full"));
        }
    }
}
