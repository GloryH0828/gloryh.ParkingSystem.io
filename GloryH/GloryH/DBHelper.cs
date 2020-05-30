using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GloryH
{
    class DBHelper
    {
        string connectionString = "server=localhost;user id=root;database=dbtest;password=123";
        public void ADD(string sql)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand mc = new MySqlCommand(sql, connection);
            connection.Open();
            int result = mc.ExecuteNonQuery();
            connection.Close();
           
        }
        public void DEL(string sql)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand mc = new MySqlCommand(sql, connection);
            connection.Open();
            int result = mc.ExecuteNonQuery();
            connection.Close();
        }
        public int UPD(string sql)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand mc = new MySqlCommand(sql, connection);
            connection.Open();
            int result = mc.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        public DataTable SEA(string sql)
        {
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection);
            mda.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}
