using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace winform_test1
{
    public partial class Login : Form
    {
        public Login()
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
        public DataTable GetDataTable (string sql)
        {
            DataTable table = new DataTable();
            string str = "Data Source=.;Initial Catalog=exam1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(table);
            return table;
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            string sql = "select * from t_user where userid='"+this.tb_userid.Text+"'";
            DataTable data = GetDataTable(sql);
            if (this.rbtn_admin.Checked==true)
            {
                if (data.Rows[0]["usertype"].ToString().Trim()=="admin")
                {
                    if (this.tb_pwd.Text == data.Rows[0]["pwd"].ToString().Trim())
                    {
                        MessageBox.Show("登录成功");
                        sql = "update t_user set ltime='"+DateTime.Now+"' where userid='"+this.tb_userid.Text+"'";
                        exsql(sql);
                        Admin_Main admin = new Admin_Main();
                        this.Hide();
                        admin.ShowDialog();
                        this.tb_userid.Text = "";
                        this.tb_pwd.Text = "";
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("密码错误");
                    }
                   
                }
                else
                {
                    MessageBox.Show("用户权限不正确");
                }
            }
            if (this.rbtn_client.Checked == true)
            {
                if (data.Rows[0]["usertype"].ToString().Trim() == "client")
                {
                    if (this.tb_pwd.Text == data.Rows[0]["pwd"].ToString().Trim())
                    {
                        Data.UID = this.tb_userid.Text;
                        string sql1 = "select * from t_user where userid='" + this.tb_userid.Text + "'";
                        DataTable table = GetDataTable(sql1);
                        Data.ADDR = table.Rows[0]["adress"].ToString().Trim();

                        MessageBox.Show("登录成功");
                        sql = "update t_user set ltime='" + DateTime.Now + "' where userid='" + this.tb_userid.Text + "'";
                        exsql(sql);
                        Client_Main client = new Client_Main();
                        this.Hide();
                        client.ShowDialog();
                        this.tb_userid.Text = "";
                        this.tb_pwd.Text = "";
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("密码错误");
                    }

                }
                else
                {
                    MessageBox.Show("用户权限不正确");
                }
            }
            if (this.rbtn_op.Checked == true)
            {
                if (data.Rows[0]["usertype"].ToString().Trim() == "op")
                {
                    if (this.tb_pwd.Text == data.Rows[0]["pwd"].ToString().Trim())
                    {
                        MessageBox.Show("登录成功");
                        sql = "update t_user set ltime='" + DateTime.Now + "' where userid='" + this.tb_userid.Text + "'";
                        exsql(sql);
                        Op_Main op = new Op_Main();
                        this.Hide();
                        op.ShowDialog();
                        this.tb_userid.Text = "";
                        this.tb_pwd.Text = "";
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("密码错误");
                    }

                }
                else
                {
                    MessageBox.Show("用户权限不正确");
                }
            }


        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            this.Hide();
            reg.ShowDialog();
            this.Show();
        }
    }
}
