using System.Drawing;
using System.Data.SQLite;
using System;
using System.Windows.Forms;

namespace MonremSys
{
    class SentRemittance : Remittance
    {
        protected string destination;
        protected bool isSent = true;
        public bool IsValid => Sender.IsValid && Receiver.IsValid && IsValidaDestination() && Transfercurrency.IsValid && (Amount>0) && !Sender.Equals(Receiver);

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public bool IsSent
        {
            get { return isSent; }
            set { isSent = value; }
        }

        public override Bitmap GenReceipt(string template_path)
        {

            PointF id_location = new PointF(90, 195);
            PointF receiver_location = new PointF(190, 280);
            PointF sender_location = new PointF(190, 340);
            PointF phone_number_location = new PointF(260, 403);
            PointF amount_location = new PointF(190, 465);
            PointF destination_location = new PointF(230, 525);
            PointF date_location = new PointF(670, 195);
            PointF description_location = new PointF(230, 635);
            // _____________________ Company Details ________________
            PointF company_name_location = new PointF(225, 20);
            PointF ph_number_location = new PointF(350, 80);
            PointF address_location = new PointF(350, 110);
            PointF emial_location = new PointF(350, 140);

            try
            {
                Bitmap ReceiptImage = (Bitmap)Image.FromFile(template_path); //load the  template image file
                using (Graphics graphics = Graphics.FromImage(ReceiptImage))
                {
                    using (Font arialFont = new Font("Candara", 22))
                    {
                        graphics.DrawString(this.Receiver.Name, arialFont, Brushes.Black, receiver_location);
                        graphics.DrawString(this.Sender.Name, arialFont, Brushes.Black, sender_location);
                        graphics.DrawString(this.Receiver.Phone_number, arialFont, Brushes.Black, phone_number_location);
                        graphics.DrawString(String.Format("{0:n0}", this.Amount) +" "+ this.Transfercurrency.Name.ToString(), arialFont, Brushes.Black, amount_location);
                        graphics.DrawString(this.Description, arialFont, Brushes.Black, description_location);
                        graphics.DrawString(this.Destination, arialFont, Brushes.Black, destination_location);
                        

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
                        graphics.DrawString(Settings1.Default.CompanyEmail, font, Brushes.Black, emial_location);
                        
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

        public override string ToString()
        {
            return $"Receiver: {this.Receiver.Name} - {this.Receiver.Phone_number}\n\n Sender: {this.Sender.Name} - {this.Sender.Phone_number}\n\nDestination: {this.Destination}\n\nAmount: {this.amount} {this.Transfercurrency.Name}\n\nRate: {Transfercurrency.Rate} \n\nCommssion: {comission}\n\nCreated At: {createdAt}";
        }
        public string ToString(string format)
        {
            string output = "";
            if (format == "full")
            {
                output = $@"Receiver Name| {this.Receiver.Name},
Receiver Phone Number| {this.Receiver.Phone_number},
Sender Name| {this.Sender.Name},
Sender Phone Number| {this.Receiver.Phone_number},
Destination| {this.Destination},
Amount| {this.Amount} {this.Transfercurrency.Name},
Rate| {this.Transfercurrency.Rate},
Commission| {this.Comission},
Description| {this.Description},
Create At| {this.CreatedAt}";
            }
            else if (format == "short")
            {
                output = $"{Receiver.Name}\n\n{Receiver.Phone_number}\n\n{Destination}\n\n*{Amount} {Transfercurrency.Name}*\n\nمرسل: {Sender.Name}";
            }
            else if (format == "receipt")
            {
                output = $"ID:{Id}\n\n{Receiver.Name}\n\n{Receiver.Phone_number}\n\n{Destination}\n\n*{Amount} {Transfercurrency.Name}*\n\nDate: {CreatedAt.ToString("MM - dd - yyyy")}";
            }
            return output;
        }
        /*--------------------------------Database Management Function-----------------------------------*/

        public override void AddintoDb()
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql = "insert into sent_remittance values (Null,@sender,@receiver,@amount,@created_at,@destination,@rate,@currency,@description,@comission)";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            cmd.Parameters.AddWithValue("@sender", this.Sender.AddintoDb());
            cmd.Parameters.AddWithValue("@receiver", this.Receiver.AddintoDb());
            cmd.Parameters.AddWithValue("@amount", this.Amount);
            cmd.Parameters.AddWithValue("@created_at", this.CreatedAt);
            cmd.Parameters.AddWithValue("@destination", this.Destination);
            cmd.Parameters.AddWithValue("@rate", this.Transfercurrency.Rate);
            cmd.Parameters.AddWithValue("@currency", this.Transfercurrency.Name);
            cmd.Parameters.AddWithValue("@description", this.Description);
            cmd.Parameters.AddWithValue("@comission", this.Comission);

            if (DbManager.ExecuteCommand(cmd))
            {
                DbManager.UpdateBox(this, con, false);
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
            string sql = "update sent_remittance set sender=@sender, receiver=@receiver,description=@description where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@id", this.Id);
            cmd.Parameters.AddWithValue("@sender", this.Sender.UpdateinDb());
            cmd.Parameters.AddWithValue("@receiver", this.Receiver.UpdateinDb());
            cmd.Parameters.AddWithValue("@description", this.Description);
            DbManager.ExecuteCommand(cmd);
            DbManager.CloseConnection(con);

        }

        public override void DeletefromDb()
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql = "delete from sent_remittance where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@id", this.Id);

            if (DbManager.ExecuteCommand(cmd))
            {
                this.Comission = -1 * this.Comission;
                this.Description = string.Format("Undo operation from: {0} Remittance.", this.Receiver.Name);
                DbManager.UpdateBox(this, con, true);
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
            string sql_command = "select * from sent_remittance where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql_command, con);
            cmd.Parameters.AddWithValue("@id", id);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    //Currency Data
                    cy.Name = (CurrencyName)rdr.GetInt16(7);
                    cy.Rate = rdr.GetFloat(6);
                    //Customers Data
                    this.Receiver = new Customer().RetrievefromDb(rdr.GetInt16(2));
                    this.Sender = new Customer().RetrievefromDb(rdr.GetInt16(1));
                    //Other data
                    this.Id = rdr.GetInt32(0);
                    this.Amount = rdr.GetInt32(3);
                    this.Comission = rdr.GetFloat(9);
                    this.CreatedAt = rdr.GetDateTime(4);
                    this.Transfercurrency = cy;
                    this.Description = rdr.GetString(8);
                    this.Destination = rdr.GetString(5);
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

        //  ------------------------------------- Validation -------------------------------

        private bool IsValidaDestination()
        {
            return !string.IsNullOrEmpty(Destination) /*and regex match*/;
        }

     
    }
}
