using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonremSys
{
    class Destination
    {
        private int id;

        private string name;

        private DateTime added_at;

        private bool is_active;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Added_at { get => added_at; set => added_at = value; }
        public bool Is_active { get => is_active; set => is_active = value; }
        public bool IsValid => !string.IsNullOrEmpty(this.Name);

        /*----------------------------- Database Mnagement functions ---------------------------*/
        public void AddintoDb()
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql_command_text;
            SQLiteCommand cmd;
            /*Add Destination or ignore if exists*/
            sql_command_text = "insert or ignore into destination (name,active) values (@name,@active);";
            cmd = new SQLiteCommand(sql_command_text, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@name", this.Name);
            cmd.Parameters.AddWithValue("@active", this.Is_active);
            DbManager.ExecuteCommand(cmd);
            DbManager.CloseConnection(con);
        }

        public void UpdateinDb()
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql_command_text;
            SQLiteCommand cmd;
            /*Update Destination to new info*/
            sql_command_text = "update destination set name=@name,active=@active where id=@id;";
            cmd = new SQLiteCommand(sql_command_text, con);
            cmd.CommandText = sql_command_text;
            cmd.Parameters.AddWithValue("@id", this.Id);
            cmd.Parameters.AddWithValue("@active", this.Is_active);
            cmd.Parameters.AddWithValue("@name", this.Name);
            DbManager.ExecuteCommand(cmd);
            DbManager.CloseConnection(con);
        }

        internal object RetrievefromDb(int id)
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql_command = "select * from destination where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql_command, con);
            cmd.Parameters.AddWithValue("@id", id);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    this.Id = rdr.GetInt16(0);
                    this.Name = rdr.GetString(1);
                    this.Is_active = rdr.GetBoolean(3);
                    this.Added_at = rdr.GetDateTime(2);
                }
                DbManager.CloseConnection(con);
                return this;
            }

            else
            {
                return null;
            }
        }

        public void DeletefromDb()
        {
            SQLiteConnection con = DbManager.GetDbConnection();
            DbManager.OpenConnection(con);
            string sql_command = "delete from destination where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql_command, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            DbManager.ExecuteCommand(cmd);
            DbManager.CloseConnection(con);
        }

    }
}
