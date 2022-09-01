using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace MonremSys
{
    class Payment : Transfer
    {
        // if it`s sent or received
        private bool type = true;

        public bool Type
        {
            get { return type; }
            set { type = value; }
        }
        public bool IsValid => !(string.IsNullOrEmpty(this.Description)) && this.Amount > 5;
        public override string ToString()
        {
            return $"Description: {Description}\n\nAmount: {string.Format("{0:n}", this.Amount)} {Transfercurrency.Name}";
        }
        public string ToString(string format)
        {
            string output = "";
            if (format == "full")
            {
                output = $@"Description| {this.Description}
Amount| {string.Format("{0:n}", this.Amount)} {this.Transfercurrency.Name}
Rate| {this.Transfercurrency.Rate}
Commission| {this.Comission}
Create At| {this.CreatedAt}";
            }
            return output;
        }

        public override Bitmap GenReceipt(string template_path)
        {

            PointF id_location = new PointF(90, 195);
            PointF amount_location = new PointF(190, 455);
            PointF date_location = new PointF(670, 195);
            PointF description_location = new PointF(210, 340);
            // ___________________ Company Details ________________
            PointF company_name_location = new PointF(225, 20);
            PointF ph_number_location = new PointF(350, 80);
            PointF address_location = new PointF(350, 110);
            PointF email_location = new PointF(350, 140);
            try
            {
                Bitmap ReceiptImage = (Bitmap)Image.FromFile(template_path); //load the  template image file
                using (Graphics graphics = Graphics.FromImage(ReceiptImage))
                {
                    using (Font arialFont = new Font("Candara", 22))
                    {
                        if (this.Type)
                            graphics.DrawString("Payment from:" + this.Description, arialFont, Brushes.Black, description_location);
                        else
                            graphics.DrawString("Payment for:" + this.Description, arialFont, Brushes.Black, description_location);
                            graphics.DrawString(string.Format("{0:n}", this.Amount), arialFont, Brushes.Black, amount_location);


                    }
                    using (Font font = new Font("Segoe UI Mono", 18))
                    {
                        graphics.DrawString(this.Id.ToString(), font, Brushes.Black, id_location);
                        graphics.DrawString(this.CreatedAt.ToString("MM-dd-yyyy"), font, Brushes.Black, date_location);

                    }

                    using (Font font = new Font("Candara", 18))
                    {

                        graphics.DrawString(Settings1.Default.CompanyPhNumber, font, Brushes.Black, ph_number_location);
                        graphics.DrawString(Settings1.Default.CompanyAddress, font, Brushes.Black, address_location);
                        graphics.DrawString(Settings1.Default.CompanyAddress, font, Brushes.Black, email_location);

                    }

                    using (Font font = new Font("Bahnschrift SemiBold", 36))
                    {
                        graphics.DrawString(Settings1.Default.CompanyName, font, Brushes.DarkBlue, company_name_location);

                    }

                }
                return ReceiptImage;
            }
            catch (Exception Error)
            {
                MessageBox.Show("Technical Erorr:" + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }






        /*--------------------------------Database Management Function-----------------------------------*/
        public override void AddintoDb()
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql = "insert into payment values (Null,@payment_date,@amount,@rate,@currency,@description,@comission,@type)";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            //parametrs
            cmd.Parameters.AddWithValue("@payment_date", this.CreatedAt);
            cmd.Parameters.AddWithValue("@amount", this.Amount);
            cmd.Parameters.AddWithValue("@rate", this.Transfercurrency.Rate);
            cmd.Parameters.AddWithValue("@currency", this.Transfercurrency.Name);
            cmd.Parameters.AddWithValue("@description", this.Description);
            cmd.Parameters.AddWithValue("@comission", this.Comission);
            cmd.Parameters.AddWithValue("@type", this.Type);

            if (DbManager.ExecuteCommand(cmd))
            {
                if (this.Type) // was received means the box will increase
                    DbManager.UpdateBox(this, con, false);
                else
                    DbManager.UpdateBox(this, con, true);
                DbManager.CloseConnection(con);
            }
            else
            {
                DbManager.CloseConnection(con);
                return;
            }


        }

        public override void EditinDb()
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql = "update payment set description=@description where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@description", this.Description);
            DbManager.ExecuteCommand(cmd);
            DbManager.CloseConnection(con);
        }

        public override void DeletefromDb()
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            Console.WriteLine("I am Here");
            string sql = "delete from payment where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@id", this.Id);

            if (DbManager.ExecuteCommand(cmd))
            {
                Comission = -1 * Comission;
                Description = string.Format("Undo operation from: {0}", Description);
                if (this.Type)
                    DbManager.UpdateBox(this, con, true);
                else
                    DbManager.UpdateBox(this, con, false);
                DbManager.CloseConnection(con);
            }
            else
            {
                DbManager.CloseConnection(con);
                return;
            }
               
        }

        public override Transfer RetrievefromDb(int id)
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            Currency cy = new Currency();
            string sql_command = "select * from payment where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql_command, con);
            cmd.Parameters.AddWithValue("@id", id);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    //Currency Data
                    cy.Name = (CurrencyName)rdr.GetInt16(4);
                    cy.Rate = rdr.GetFloat(3);

                    //Payment data
                    this.Id = rdr.GetInt16(0);
                    this.CreatedAt = rdr.GetDateTime(1);
                    this.Amount = rdr.GetInt32(2);
                    this.Transfercurrency = cy;
                    this.Description = rdr.GetString(5);
                    this.Comission = rdr.GetFloat(6);
                    this.Type = rdr.GetBoolean(7);
                }
                DbManager.CloseConnection(con);
                return this;
            }

            else
            {
                DbManager.CloseConnection(con);
                return null;
            }
                

        }


    }

}
