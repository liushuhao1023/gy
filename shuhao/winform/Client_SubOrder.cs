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
    public partial class Client_SubOrder : Form
    {
        public Client_SubOrder()
        {
            InitializeComponent();
        }
        public void exsql(string sql)
        {
            string str = "Data Source=.;Initial Catalog=exam1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable GetDataTable(string sql)
        {
            DataTable table = new DataTable();
            string str = "Data Source=.;Initial Catalog=exam1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(table);
            return table;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string id = Data.UID;
            string adress = Data.ADDR;
            string cp = (this.comboBox1.SelectedIndex+1).ToString();
            string sql1 = "select * from cp where id='"+cp+"'";
            DataTable data = GetDataTable(sql1);
            string pm1 = data.Rows[0]["pm1"].ToString().Trim();
            string pm2 = data.Rows[0]["pm2"].ToString().Trim();
            string qty = this.textBox2.Text;

            string sql2 = "insert into t_order(orderid,userid,adress,pm1,pm2,qty,otime)" +
                "values('"+this.textBox1.Text+ "','" + id + "','" + adress + "','" + pm1 + "'" +
                ",'" + pm2 + "','" + qty + "','" + DateTime.Now + "') ";
            exsql(sql2);
            MessageBox.Show("下单成功");
        }

        private void Client_SubOrder_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“exam1DataSet.cp”中。您可以根据需要移动或删除它。
            this.cpTableAdapter.Fill(this.exam1DataSet.cp);

        }
    }
}
