using System;
using System.Windows.Forms;

namespace MonremSys
{
    public partial class Dashboard : Form
    {
        string today;
        string tomorrow;
        public Dashboard()
        {
            InitializeComponent();
            today = DateTime.Now.Date.ToString("yyyy-MM-dd");
            tomorrow = DateTime.Now.Date.AddDays(1).ToString("yyyy-MM-dd");
            
        }

        public string Compute(string table_name)
        {
            string query = string.Format(DbManager.Commands[table_name],this.today,this.tomorrow);
            string outt= DbManager.GetValueofQ(query);
            return outt ;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            sentRemTotalLbl.Text = Compute("SentRemTotal")+" $";
            receivedRemTotalLbl.Text= Compute("RecRemTotal") + " $";
            sentPaysTotalLbl.Text = Compute("SentPayTotal") + " $";
            receivedPaysTotalLbl.Text = Compute("RecPayTotal") + " $";
            
            outBoxLbl.Text = Compute("OutboxTotal") + " $";
            currentCreditLbl.Text = DbManager.GetValueofQ(DbManager.Commands["CurrentCreditAmount"]) + " $";
            sentRemCountLbl.Text = Compute("SentRemCount");
            receivedRemCountLbl.Text = Compute("RecRemCount");
            sentPaysCountLbl.Text = Compute("SentPayCount");
            receivedPaysCountLbl.Text = Compute("RecPayCount");
            paidTodayCountLbl.Text = Compute("PaidTodayCount");
            paidTodayTotalLbl.Text = Compute("PaidTodayAmount") + " $";
            notPaidAmountLbl.Text = DbManager.GetValueofQ(DbManager.Commands["NotPaidAmount"]) + " $";
            notPaidCountLbl.Text = DbManager.GetValueofQ(DbManager.Commands["NotPaidCount"]);

        }
    }
}
