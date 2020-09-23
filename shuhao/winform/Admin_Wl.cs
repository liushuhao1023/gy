using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_test1
{
    public partial class Admin_Wl : Form
    {
        public Admin_Wl()
        {
            InitializeComponent();
        }

        private void Admin_wl_Load(object sender, EventArgs e)
        {
            Info_Table();
        }

        public void Info_Table()
        {
            dataGridView1.Rows.Clear();
            string str = "Data Source=.;Initial Catalog=exam1;Integrated Security=True";
            string sql = "select * from wl";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            IDataReader dc = cmd.ExecuteReader();
            while (dc.Read())
            {
                string id = dc[0].ToString();
                string mid = dc[1].ToString();
               // string type = dc[2].ToString();
                string color = dc[3].ToString();
              //  string caizhi = dc[4].ToString();
               // string num = dc[5].ToString();
                dataGridView1.Rows.Add(id, mid, color);
            }
            dc.Close();
            conn.Close();
        }
    }
}
