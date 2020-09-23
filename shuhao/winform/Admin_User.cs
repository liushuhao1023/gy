using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace winform_test1
{
    public partial class Admin_User : Form
    {
        public Admin_User()
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

        private void Admin_User_Load(object sender, EventArgs e)
        {
            Info_Table();
            Right_Table();
        }

        public void Info_Table()
        {
            dataGridView1.Rows.Clear();
            string str = "Data Source=.;Initial Catalog=exam1;Integrated Security=True";
            string sql = "select * from t_user";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            IDataReader dc = cmd.ExecuteReader();
            while (dc.Read())
            {
                string userid = dc[0].ToString();
                string pwd = dc[1].ToString();
                string adress = dc[2].ToString();
                string usertype = dc[3].ToString();
                string ltime = dc[4].ToString();
                dataGridView1.Rows.Add(userid, pwd, adress, usertype, ltime);
            }
            dc.Close();
            conn.Close();
        }

        public void Right_Table()
        {
            dataGridView2.Rows.Clear();
            string str = "Data Source=.;Initial Catalog=exam1;Integrated Security=True";
            string sql = "select * from [right]";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            IDataReader dc = cmd.ExecuteReader();
            while (dc.Read())
            {
                string usertype = dc[0].ToString();
                string sub_o = dc[1].ToString();
                string uadmin = dc[2].ToString();
                string op = dc[3].ToString();
                string cs = dc[4].ToString();
                string wl = dc[5].ToString();
                dataGridView2.Rows.Add(usertype, sub_o, uadmin, op, cs, wl);
            }
            dc.Close();
            conn.Close();
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                string userid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr==DialogResult.OK)
                {
                    string sql = "delete from t_user where userid='"+userid+"'";
                    exsql(sql);
                    MessageBox.Show("删除成功");
                    Info_Table();
                }


            }
            catch (Exception)
            {
                MessageBox.Show("请先选择要删除的用户","信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ResetPwd_Click(object sender, EventArgs e)
        {
            try
            {
                string userid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("确认重置吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = "update t_user set pwd='"+userid+"' where userid='"+userid+"'";
                    exsql(sql);
                    MessageBox.Show("重置成功");
                    Info_Table();
                }


            }
            catch (Exception)
            {
                MessageBox.Show("请先选择要重置密码的用户", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
