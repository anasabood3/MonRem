using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace MonremSys
{
    static class DbManager
    {
        //should be external
        public static Dictionary<string, string> Commands = new Dictionary<string, string>(){
            {"SentRemTotal", "select sum(value) from sent_remittance where created_at between '{0}' and '{1}';"},
            {"SentRemCount", "select count(value) from sent_remittance where created_at between '{0}' and '{1}';"},

            {"RecRemTotal", "select sum(value) from received_remittance where created_at between '{0}' and '{1}';"},
            {"RecRemCount", "select count(value) from received_remittance where created_at between '{0}' and '{1}';"},
            {"NotPaidAmount", "select sum(value) from received_remittance where is_paid == false;"},
            {"NotPaidCount", "select count(value) from received_remittance where is_paid == false;"},
            {"PaidTodayAmount", "select sum(value) from received_remittance where paid_at between '{0}' and '{1}' and is_paid == true;"},
            {"PaidTodayCount", "select count(value) from received_remittance where paid_at between '{0}' and '{1}' and is_paid == true;"},

            {"SentPayTotal", "select sum(value) from payment where payment_date between '{0}' and '{1}' and type=0;"},
            {"SentPayCount", "select count(value) from payment where payment_date between '{0}' and '{1}' and type=0;"},

            {"RecPayTotal", "select sum(value) from payment where payment_date between '{0}' and '{1}' and type=1;"},
            {"RecPayCount", "select count(value) from payment where payment_date between '{0}' and '{1}' and type=1;"},





            {"InboxTotal", "select sum(amount) from box where added_at between '{0}' and '{1}' and amount > 0;"},
            {"OutboxTotal", "select sum(amount) from box where added_at between '{0}' and '{1}' and amount < 0;"},
            {"CurrentCreditAmount","select credit,max(id) from box;" }

            };

        public static string[] history = {
                DateTime.Today.ToString("yyyy-MM-dd"),
                DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"),
                DateTime.Today.AddDays(-7).ToString("yyyy-MM-dd"),
                new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1).ToString("yyyy-MM-dd"),
                "2020-01-01"};

        //Database  Connection Initialization
        public static SQLiteConnection DbConnection;
        public static SQLiteConnection GetDbConnection()
        {
            if (!File.Exists("../../Data/DB.db"))
            {
                MessageBox.Show("Error While lading Database, Try Reinstalling program or locate database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }
            DbConnection = new SQLiteConnection("Data Source=../../Data/DB.db;foreign keys=true;");
            return DbConnection;
        }


        //Database Connection Opening
        public static void OpenConnection(SQLiteConnection con)
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error While Connecting Database:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Database Connection Closing
        public static void CloseConnection(SQLiteConnection con)
        {
            if (con.State != System.Data.ConnectionState.Closed)
            {
                try
                {
                    con.Close();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error While Closing:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        //Fill Datagridview
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            SQLiteConnection con = GetDbConnection();
            OpenConnection(con);
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);
            System.Data.DataTable tbl = new System.Data.DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            CloseConnection(con);
        }
        // True if Successeded or False when fails
        public static bool ExecuteCommand(SQLiteCommand cmd)
        {
            int result = 0;
            try
            {
                result = cmd.ExecuteNonQuery(); // returns number of affected rows in database
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error While Saving Changes." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result > 0;
        }

        


        // inverse is a boolean toggle to set amount status in front of the box exported/imported
        public static void UpdateBox(Transfer transfer, SQLiteConnection con, bool inverse)
        {
            float last_credit_value;
            float transfer_value;
            if (inverse)
            {
                transfer_value = (-1 * transfer.Amount / transfer.Transfercurrency.Rate) + transfer.Comission;
            }
            else
            {
                transfer_value = (transfer.Amount / transfer.Transfercurrency.Rate) + transfer.Comission;
            }
            last_credit_value = (float)Convert.ToDouble(GetValueofQ(Commands["CurrentCreditAmount"]));
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "insert into box values(null,null,null,null,@added_at,@description,@amount,@new_credit);";
            cmd.Parameters.AddWithValue("@added_at", DateTime.Now);
            cmd.Parameters.AddWithValue("@description", transfer.Description);
            cmd.Parameters.AddWithValue("@amount", transfer_value);
            cmd.Parameters.AddWithValue("@new_credit", last_credit_value + transfer_value);
            ExecuteCommand(cmd);
        }
        // Get the lated added element in datatable
        public static int GetLastId(SQLiteConnection con, string table)
        {
            int last_id;
            string sql_command = "select max(id) from @table";
            SQLiteCommand cmd = new SQLiteCommand(sql_command, con);
            cmd.Parameters.AddWithValue("@name", table);
            object result = cmd.ExecuteScalar();
            result = (result == DBNull.Value) ? 0 : result;
            last_id = Convert.ToInt16(result);
            return last_id;
        }

        // UI Managemt Fucntions
        // Auto Complete TextBox Initialzation 
        public static AutoCompleteStringCollection GetSuggestionCollection(string table,string field)
        {
            SQLiteConnection con = GetDbConnection();
            OpenConnection(con);
            string sql = string.Format("select {1} from {0};",table,field);
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            SQLiteDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection SuggestionCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                SuggestionCollection.Add(reader.GetString(0));
            }
            CloseConnection(con);
            return SuggestionCollection;
        }
        // Get Numerical Value According to the input query

        public static string GetValueofQ(string query)
        {


            SQLiteConnection con = GetDbConnection();
            OpenConnection(con);
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            object result = cmd.ExecuteScalar();

            if (result!=DBNull.Value)
            {
                double output = Math.Round(Convert.ToDouble(result),2);
                return output.ToString("N");

            }

            return "0";

        }

        public static void ClearAllData()
        {
            List<string> tables_names = new List<string>() { "payment", "received_remittance", "sent_remittance", "box","customer"};
            SQLiteConnection con = GetDbConnection();
            OpenConnection(con);
            SQLiteCommand cmd = new SQLiteCommand("", con);
           
            foreach (string table in tables_names)
            {
                cmd.CommandText= $"delete from {table}";
                cmd.ExecuteNonQuery();
            }
            CloseConnection(con);

        }

    }
}
