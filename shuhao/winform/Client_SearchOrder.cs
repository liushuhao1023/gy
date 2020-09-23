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
    public partial class Client_SearchOrder : Form
    {
        public Client_SearchOrder()
        {
            InitializeComponent();
        }

        public void Info_Table()
        {
            string id = Data.UID;
            dataGridView1.Rows.Clear();
            string str = "Data Source=.;Initial Catalog=exam1;Integrated Security=True";
            string sql = "select * from t_order where userid='"+id+"'";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            IDataReader dc = cmd.ExecuteReader();
            while (dc.Read())
            {
                string orderid = dc[0].ToString();
                string userid = dc[1].ToString();
                string adress = dc[2].ToString();
                string pm1 = dc[3].ToString();
                string pm2 = dc[4].ToString();
                string qty = dc[5].ToString();
                string fqty = dc[6].ToString();
                string rqty = dc[7].ToString();
                string otime = dc[8].ToString();
                string ftime = dc[9].ToString();
                dataGridView1.Rows.Add(orderid, userid, adress, pm1, pm2, qty, fqty, rqty, otime, ftime);
            }
            dc.Close();
            conn.Close();
        }

        private void Client_SearchOrder_Load(object sender, EventArgs e)
        {
            Info_Table();
        }
    }
}
