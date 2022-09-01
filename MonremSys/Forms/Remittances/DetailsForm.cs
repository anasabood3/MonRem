using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonremSys.Forms.Remittances
{
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
            detailsBindingSource.Clear();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            detailsLv.Items.Clear();
            Remittance Rmnc = detailsBindingSource.Current as Remittance;

            if (Rmnc is SentRemittance)
            {
                foreach (var detail in (Rmnc as SentRemittance).ToString("full").Split(','))
                {
                    detailsLv.Items.Add(new ListViewItem(detail.Split('|')));
                }
            }
            else if (Rmnc is ReceivedRemittance){
                foreach (var detail in (Rmnc as ReceivedRemittance).ToString("full").Split(','))
                {
                    detailsLv.Items.Add(new ListViewItem(detail.Split('|')));
                }
            }


        }

        private void CopyFullDetails(object sender, EventArgs e)
        {
            Remittance Rmnc = detailsBindingSource.Current as Remittance;
            if (Rmnc is SentRemittance)
            {
                Clipboard.SetText((Rmnc as SentRemittance).ToString("full"));
            }
            else if (Rmnc is ReceivedRemittance)
            {
                Clipboard.SetText((Rmnc as ReceivedRemittance).ToString("full"));
            }
           
        }
    }
}
