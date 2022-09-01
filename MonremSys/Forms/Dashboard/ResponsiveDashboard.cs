using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonremSys.Forms.Dashboard
{
    public partial class ResponsiveDashboard : Form
    {
        string today;
        string tomorrow;

        public ResponsiveDashboard()
        {
            InitializeComponent();
            today = DateTime.Now.Date.ToString("yyyy-MM-dd");
            tomorrow = DateTime.Now.Date.AddDays(1).ToString("yyyy-MM-dd");

        }

        public string Compute(string table_name)
        {
            string query = string.Format(DbManager.Commands[table_name], this.today, this.tomorrow);
            string outt = DbManager.GetValueofQ(query);
            return outt;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Sent Remittacnes Stats
            sentRemTotalLbl.Text = Compute("SentRemTotal") + " $";
            sentRemCountLbl.Text = Compute("SentRemCount");

            // Received Remittances List
            //All
            receivedRemTotalLbl.Text = Compute("RecRemTotal") + " $";
            receivedRemCountLbl.Text = Compute("RecPayCount");
            //Paid
            receivedPaidTotalLbl.Text = Compute("PaidTodayAmount") + " $";
            receivedPaidCountLbl.Text = Compute("PaidTodayCount");
            //Not Paid
            receivedNotPaidTotalLbl.Text = DbManager.GetValueofQ(DbManager.Commands["NotPaidAmount"]) + " $";
            receivedNotPaidCountLbl.Text = DbManager.GetValueofQ(DbManager.Commands["NotPaidCount"]);
            //Sent Pays
            sentPaysTotalLbl.Text = Compute("SentPayTotal") + " $";
            sentPaysCountLbl.Text = Compute("SentPayCount");
            //Recieved Pays
            receivedPaysTotalLbl.Text = Compute("PaidTodayAmount") + " $";
            receivedPaysCountLbl.Text = Compute("RecPayCount");


            // Credit Info
            outBoxLbl.Text = Compute("OutboxTotal") + " $";
            InBoxLbl.Text = Compute("InboxTotal") + " $";
            currentCreditLbl.Text = DbManager.GetValueofQ(DbManager.Commands["CurrentCreditAmount"]) + " $";
        }

        private void statslist2_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (StringFormat sf = new StringFormat())
            {
                // Store the column text alignment, letting it default
                // to Left if it has not been set to Center or Right.
                switch (e.Header.TextAlign)
                {
                    case HorizontalAlignment.Center:
                        sf.Alignment = StringAlignment.Center;
                        break;
                    case HorizontalAlignment.Right:
                        sf.Alignment = StringAlignment.Far;
                        break;
                }

                // Draw the standard header background.
                e.DrawBackground();

                // Draw the header text.
                using (Font headerFont =
                            new Font("Helvetica", 10, FontStyle.Bold))
                {
                    e.Graphics.DrawString(e.Header.Text, headerFont,
                        Brushes.Transparent, e.Bounds, sf);
                }
            }
            return;
        }


    }
}
