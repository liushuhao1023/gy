using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SBS
{
    public class DBOP
    {
        public static string str = "Data Source=.;Initial Catalog=part1;Integrated Security=True";

        public static void exsql(string sql)
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable GetDataTable(string sql)
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            DataTable table = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, conn);
            sqlData.Fill(table);
            conn.Close();
            return table;
        }
    }
}