using System;

using System.Windows.Forms;

namespace MonremSys.Forms.Settings
{
    public partial class Settings : Form
    {



        //Child Forms 
        DestinationManageForm manage_form;



        public Settings()
        {
            InitializeComponent();
            manage_form = new DestinationManageForm(this);
        }

        
        private void Settings_Load(object sender, EventArgs e)
        {
            LoasSettings();
            Display();
        }

        //load data from Database
        public void Display()
        {
            string qurey = @"select id,name,added_at,active from destination";
            DbManager.DisplayAndSearch(qurey, destinationsDgv);
            
        }


        // --------------------------------Items Management----------------------------



        ////Add new destination button click
        private void AddDestination(object sender, EventArgs e)
        {
            manage_form.destinationBindingSource.DataSource = new Destination();
            manage_form.ShowDialog();
        }

        private void EditItem(object sender, EventArgs e)
        {
            manage_form.destinationBindingSource.DataSource = new Destination().RetrievefromDb(Convert.ToInt32(destinationsDgv.SelectedRows[0].Cells[0].Value));
            manage_form.ShowDialog();
        }


        private void DeleteItem(object sender, EventArgs e)
        {

            if (confirmMessageDialog.Show("Are You Sure ...?", "Warning") == DialogResult.Yes)
            {
                Destination dst = (Destination)new Destination().RetrievefromDb(Convert.ToInt32(destinationsDgv.SelectedRows[0].Cells[0].Value));
                
                dst.DeletefromDb();
            }
            Display();
            return;
        }

        // --------------------------------Settings Context Menu---------------------------
        private void ViewSettingsCM(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = destinationsDgv.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    destinationsDgv.Rows[hti.RowIndex].Selected = true;
                    destinationListCMS.Show(destinationsDgv, e.Location);
                }

            }
        }

        private void LoasSettings()
        {
            companyName.Text = Settings1.Default.CompanyName;
            companyAddress.Text = Settings1.Default.CompanyAddress;
            companyPhNumber.Text = Settings1.Default.CompanyPhNumber;
            companyEmail.Text = Settings1.Default.CompanyEmail;
            safetyLevelAmout.Value = int.Parse(Settings1.Default.SafetyLevel);
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            Settings1.Default.CompanyName = companyName.Text.Trim();
            Settings1.Default.CompanyAddress = companyAddress.Text.Trim();
            Settings1.Default.CompanyPhNumber = companyPhNumber.Text.Trim();
            Settings1.Default.CompanyEmail = companyEmail.Text.Trim();
            Settings1.Default.SafetyLevel = safetyLevelAmout.Value.ToString();
            Settings1.Default.Save();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (confirmMessageDialog.Show("Loss of Data Be Careful,", "Critical Acion") == DialogResult.Yes)
            {

                DbManager.ClearAllData();
            }
            
        }
    }
}
