using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_BTL_Nhom19
{
    internal class ProcessDB
    {
       public static SqlConnection conn;
        public static void OpenConnection()
        {
            conn = new SqlConnection("Data Source=DESKTOP-P283H3V\\TESTDB;Initial Catalog=BTL;Integrated Security=True");

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();

            }
        }
        public static void CloseConnection()
        {
            conn = new SqlConnection("Data Source=DESKTOP-P283H3V\\TESTDB;Initial Catalog=BTL;Integrated Security=True");

            if (conn.State != ConnectionState.Closed)
                conn.Close();
            conn.Dispose();
        }
        public static DataTable DocBangsql(string sql)
        {
            OpenConnection();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(tb);
            CloseConnection();
            return tb;

        }
        public static void CapNhat(String sql)
        {
            SqlCommand cmd = new SqlCommand();
            OpenConnection();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            CloseConnection();
            cmd.Dispose();
        }
    }
}
