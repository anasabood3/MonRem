
using System;
using System.Drawing;
using System.Windows.Forms;
using DGVPrinterHelper;
namespace MonremSys.Forms.Box
{
    public partial class BoxList : Form
    {
        public BoxList()
        {
            InitializeComponent();


            //inintialize date values fo date range pickers
            fromDatePicker.Value = DateTime.Now;
            toDatePicker.Value = DateTime.Now.AddDays(1);
        }

        // ------------------------------ On Form Load-------------------------------
        //Display list inside DatagridView
        private void BoxList_Load(object sender, EventArgs e)
        {

            Display();
            //UpdateCreditValue();
        }

        ////Update Credit Value
        //public void UpdateCreditValue()
        //{
        //    var credit_value = (float)Convert.ToDouble(DbManager.GetValueofQ(DbManager.Commands["CurrentCreditAmount"]));
        //    if (credit_value > 0)
        //        creditValueLbl.ForeColor = System.Drawing.Color.Green;
        //    else
        //        creditValueLbl.ForeColor = System.Drawing.Color.Red;
            
        //}
        //load data from Database
        public void Display()
        {
            string from_date = fromDatePicker.Value.ToString("yyyy-MM-dd");
            string to_date = toDatePicker.Value.ToString("yyyy-MM-dd");
            string query = "select id,amount,credit,added_at,description from box WHERE added_at BETWEEN '{0}' AND '{1}';";
            DbManager.DisplayAndSearch(string.Format(query, from_date, to_date), transfersDgv);

        }


        // ------------------------------ Print Management-------------------------------
        // Printing Transfer Log
        private void printBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Transfer Report";
            printer.SubTitle = $"from {fromDatePicker.Value.ToString("yyyy-MM-dd")} to {toDatePicker.Value.ToString("yyyy-MM-dd")}";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = Settings1.Default.CompanyName;
            printer.FooterSpacing = 15;
            printer.PageSettings.Landscape=true;
            printer.PrintDataGridView(transfersDgv);
         
        }
    }
}

/*
 1- Add Printing Feature
 2- Enhance Appearance
 3- Current Value of Credti Box
 4- 
 
 */