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
    public partial class Admin_CsSet : Form
    {
        public Admin_CsSet()
        {
            InitializeComponent();
        }

        private void Admin_CsSet_Load(object sender, EventArgs e)
        {
            Info_Table();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void Info_Table()
        {
            dataGridView1.Rows.Clear();
            string str = "Data Source=.;Initial Catalog=exam1;Integrated Security=True";
            string sql = "select * from cp ";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            IDataReader dc = cmd.ExecuteReader();
            while (dc.Read())
            {
                string id = dc[0].ToString();
                string pm1 = dc[1].ToString();
                string pm2 = dc[2].ToString();
                string lx = dc[3].ToString();
                string yhsj = dc[4].ToString();
                dataGridView1.Rows.Add(id, pm1, pm2, lx, yhsj);
            }
            dc.Close();
            conn.Close();
        }

        private void yhsj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cptype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pm2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pm1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
