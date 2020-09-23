using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace winform_test1
{
    public partial class Reg : Form
    {
        public Reg()
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

        private void btn_reg_Click(object sender, EventArgs e)
        {
            string sql = "insert into t_user(userid,pwd,adress,usertype)values('"+this.tb_userid.Text+ "','" + this.tb_pwd.Text + "','" + this.cb_addr.SelectedItem.ToString().Trim() + "','client')";
            exsql(sql);
            MessageBox.Show("注册成功");
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
