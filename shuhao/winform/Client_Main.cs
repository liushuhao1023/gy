using System;
using System.Windows.Forms;

namespace winform_test1
{
    public partial class Client_Main : Form
    {
        public Client_Main()
        {
            InitializeComponent();
        }

        private void 用户下单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client_SubOrder client_SubOrder = new Client_SubOrder();
            client_SubOrder.Show();
            client_SubOrder.MdiParent = this;
        }

        private void 订单查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client_SearchOrder client_SearchOrder = new Client_SearchOrder();
            client_SearchOrder.Show();
            client_SearchOrder.MdiParent = this;
        }

        private void Client_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
