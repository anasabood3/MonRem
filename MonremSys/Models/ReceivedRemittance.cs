using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace MonremSys
{
    class ReceivedRemittance : Remittance
    {
        //private bool isPaid = false;
        //private DateTime paied_at;
        //private string payInfo = "";
        //private string payDocPath = "";


        public bool Ispaid { get; set; }
        public DateTime PaidAt { get; set; } = new DateTime();
        public string PayInfo { get; set; } = "";
        public string PayDocPath { get; set; } = "";
        public bool IsValid => Sender.IsValid && Receiver.IsValid && Transfercurrency.IsValid && (Amount > 0);
        public bool IsPayValid => !string.IsNullOrEmpty(PayDocPath) || !string.IsNullOrEmpty(PayInfo);

        public void Pay()
        {
            Ispaid = true;
            PaidAt = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Recevier: {Receiver.Name}\nPhone Number: {Receiver.Phone_number}\nAmount: {amount} {Transfercurrency.Name} \nStatus: {Ispaid} \nPaying Date: {PaidAt} \nSender: {Sender.Name}";
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
Amount| {this.Amount} {this.Transfercurrency.Name},
Rate| {this.Transfercurrency.Rate},
Commission| {this.Comission},
Description| {this.Description},
Create At| {this.CreatedAt},
Is Paid| {this.Ispaid},
Paid At|{this.PaidAt}";
            }
            else if (format == "short")
            {
                output = $"{Receiver.Name}\n\n{Receiver.Phone_number}\n\n*{Amount} {Transfercurrency.Name}*\n\nمرسل: {Sender.Name}";
            }
            return output;
        }


        public override Bitmap GenReceipt(string template_path)
        {

            PointF sender_location = new PointF(440, 222);
            try
            {
                Bitmap ReceiptImage = (Bitmap)Image.FromFile(template_path); //load the  template image file
                using (Graphics graphics = Graphics.FromImage(ReceiptImage))
                {
                    using (Font arialFont = new Font("Arial", 12))
                    {

                        graphics.DrawString(this.Amount.ToString() + " " + this.Transfercurrency.Name.ToString(), arialFont, Brushes.DarkBlue, meta["amount_location"]);
                        //graphics.DrawString(this.Description, arialFont, Brushes.DarkBlue, meta["description_location"]);
                        graphics.DrawString(this.Id.ToString(), arialFont, Brushes.DarkBlue, meta["id_location"]);
                        graphics.DrawString(this.Receiver.Name, arialFont, Brushes.DarkBlue, meta["receiver_location"]);

                    }
                    using (Font font = new Font("Arial", 11))
                    {
                        graphics.DrawString(this.CreatedAt.ToString(), font, Brushes.DarkBlue, meta["date_location"]);
                        graphics.DrawString(this.Sender.Name, font, Brushes.DarkBlue, sender_location);

                    }
                }
                return ReceiptImage;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Caught");
                MessageBox.Show("Technical Erorr:" + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /*--------------------------------Database Management Function-----------------------------------*/
        public override void AddintoDb()
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql = "insert into received_remittance values (Null,@sender,@receiver,@amount,@created_at,@paid_at,@is_paid,@pay_info,@pay_doc_path,@rate,@currency,@description,@comission)";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@sender", this.Sender.AddintoDb());
            cmd.Parameters.AddWithValue("@receiver", this.Receiver.AddintoDb());
            cmd.Parameters.AddWithValue("@amount", this.Amount);
            cmd.Parameters.AddWithValue("@created_at", this.CreatedAt);
            cmd.Parameters.AddWithValue("@paid_at", this.PaidAt);
            cmd.Parameters.AddWithValue("@is_paid", this.Ispaid);
            cmd.Parameters.AddWithValue("@pay_info", this.PayInfo);
            cmd.Parameters.AddWithValue("@pay_doc_path", this.PayDocPath);
            cmd.Parameters.AddWithValue("@rate", this.Transfercurrency.Rate);
            cmd.Parameters.AddWithValue("@currency", this.Transfercurrency.Name);
            cmd.Parameters.AddWithValue("@description", this.Description);
            cmd.Parameters.AddWithValue("@comission", this.Comission);
            DbManager.ExecuteCommand(cmd);
            DbManager.CloseConnection(con);
        }

        public override void EditinDb()
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql = "update received_remittance set sender=@sender, receiver=@receiver, paid_at=@paid_at, is_paid=@is_paid, pay_info=@pay_info, pay_doc_path=@pay_doc_path, description=@description where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@id", this.Id);
            cmd.Parameters.AddWithValue("@sender", this.Sender.UpdateinDb());
            cmd.Parameters.AddWithValue("@receiver", this.Receiver.UpdateinDb());
            cmd.Parameters.AddWithValue("@paid_at", this.PaidAt);
            cmd.Parameters.AddWithValue("@is_paid", this.Ispaid);
            cmd.Parameters.AddWithValue("@pay_info", this.PayInfo);
            cmd.Parameters.AddWithValue("@pay_doc_path", this.PayDocPath);
            cmd.Parameters.AddWithValue("@description", this.Description);

            if (DbManager.ExecuteCommand(cmd))
            {
                if (this.Ispaid)
                    DbManager.UpdateBox(this, con, true);
                DbManager.CloseConnection(con);
            }
            else
            {
                DbManager.CloseConnection(con);
                return;
            }
        }



        public override void DeletefromDb()
        {
            if (this.Ispaid)
            {
                MessageBox.Show("Security Restriction, You Cannot Delete any remittance after paying", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
                SQLiteConnection con = DbManager.GetDbConnection();
                DbManager.OpenConnection(con);
                string sql = "delete from received_remittance where id=@id";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", Id);
                DbManager.ExecuteCommand(cmd);
                DbManager.CloseConnection(con);

                //if (DbManager.ExecuteCommand(cmd))
                //{
                //    this.Comission = -1 * this.Comission;
                //    this.Description = string.Format("Undo operation from: {0} Remittance.", this.Receiver.Name);
                //    DbManager.UpdateBox(this, con, false);
                //}
                //else
                //{
                //    return;
                //}
            }

        }

        public override Transfer RetrievefromDb(int id)
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            Currency cy = new Currency();
            string sql_command = "select * from received_remittance where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql_command, con);
            cmd.Parameters.AddWithValue("@id", id);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    //Currency Data
                    cy.Name = (CurrencyName)rdr.GetInt16(10);
                    cy.Rate = rdr.GetFloat(9);
                    //Customers Data
                    this.Receiver = new Customer().RetrievefromDb(rdr.GetInt16(2));
                    this.Sender = new Customer().RetrievefromDb(rdr.GetInt16(1));

                    //Other data
                    this.Id = rdr.GetInt32(0);
                    this.Amount = rdr.GetInt32(3);
                    this.Comission = rdr.GetFloat(12);
                    this.CreatedAt = rdr.GetDateTime(4);
                    this.Transfercurrency = cy;
                    this.Description = rdr.GetString(11);

                    //Paying Data

                    this.Ispaid = rdr.GetBoolean(6);
                    if (this.Ispaid)
                    {
                        this.PaidAt = rdr.GetDateTime(5);
                        this.PayInfo = rdr.GetString(7);
                        this.PayDocPath = rdr.GetString(8);
                    }


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
