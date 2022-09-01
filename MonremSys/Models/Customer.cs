using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace MonremSys
{
    class Customer
    {
        private int id;
        
        private string name;
        
        private string phone_number="";
        
        private string address ="";


        public string Name { get => name; set => name = value; }


        public string Phone_number { get => phone_number; set => phone_number = value; }

        public string Address { get => address; set => address = value; }
        public int Id { get => id; set => id = value; }
        public bool IsValid => isValidName() && IsValidPhoneNumber();

        public override string ToString()
        {
            return $"Name: {Name} \nPhone Number: {Phone_number} \nAddress: {this.Address}";
        }

        /*----------------------------- Database Mnagement functions ---------------------------*/
        public int AddintoDb()
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql_command_text;
            SQLiteCommand cmd;
            /*Add customer or ignore if exists*/
            sql_command_text = "insert or ignore into customer (full_name,phone_number,address) values (@customer,@customer_ph,@address);";
            cmd = new SQLiteCommand(sql_command_text, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@customer", this.Name);
            cmd.Parameters.AddWithValue("@customer_ph", this.Phone_number);
            cmd.Parameters.AddWithValue("@address", this.Address);
            var result = cmd.ExecuteNonQuery();
            /*Return ID of the customer*/
            sql_command_text = "select * from customer where full_name=@customer and phone_number = @customer_ph";
            cmd.CommandText = sql_command_text;
            int customer_id = Convert.ToInt16(cmd.ExecuteScalar());
            DbManager.CloseConnection(con);
            return customer_id;
        }

        public int UpdateinDb()
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql_command_text;
            SQLiteCommand cmd;
            /*Check User Existnce*/
            sql_command_text = "SELECT EXISTS(SELECT 1 FROM customer WHERE full_name=@customer and phone_number = @customer_ph and address=@address)";
            cmd = new SQLiteCommand(sql_command_text, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@customer", this.Name);
            cmd.Parameters.AddWithValue("@customer_ph", this.Phone_number);
            cmd.Parameters.AddWithValue("@address", this.Address);
            string result = cmd.ExecuteScalar().ToString();

            if (result == "0") // if no such info
            {
                /*Update User to new info*/
                sql_command_text = "update customer set full_name=@customer,phone_number=@customer_ph,address=@address where id=@id";
                cmd.CommandText = sql_command_text;
                cmd.ExecuteNonQuery();
                DbManager.CloseConnection(con);
                return id;
            }
            else
            {

                // what about deleting old customer
                /*Discussion*/
                // There is instance of this info
                sql_command_text = "select * from customer where full_name=@customer and phone_number = @customer_ph";
                cmd.CommandText = sql_command_text;
                int id_value = Convert.ToInt16(cmd.ExecuteScalar());
                DbManager.CloseConnection(con);
                return id_value;
            }

        }

        public void DeletefromDb()
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql_command = "delete from customer where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql_command, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            DbManager.ExecuteCommand(cmd);
            DbManager.CloseConnection(con);
        }

        public Customer RetrievefromDb(int id)
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql_command = "select * from customer where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql_command, con);
            cmd.Parameters.AddWithValue("@id", id);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    this.Id = rdr.GetInt32(0);
                    this.Name = rdr.GetString(1);
                    this.Phone_number = rdr.GetString(2);
                    this.Address = rdr.GetString(3);
                }
                DbManager.CloseConnection(con);
                return this;
            }

            else
            {
                return null;
            }
                

        }

        // ---------------------------------------- Validation Methods ----------------------------------------
        private bool IsValidPhoneNumber()
        {

            return String.IsNullOrEmpty(Phone_number) || Phone_number.Length > 3;

        }
        private bool isValidName()
        {
            return !(String.IsNullOrEmpty(Name)) && Regex.IsMatch(Name, @"[a-zA-Z 0-9أ-ي]");
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   Name == customer.Name &&
                   Phone_number == customer.Phone_number &&
                   Address == customer.Address &&
                   Id == customer.Id;
        }
    }

}
