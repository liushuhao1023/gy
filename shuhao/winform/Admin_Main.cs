using OpcUaHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_test1
{
    public partial class Admin_Main : Form
    {

        public Admin_Main()
        {
            InitializeComponent();
        }
        
        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_User admin_User = new Admin_User();
            admin_User.Show();
            admin_User.MdiParent = this;
        }

        private void 物料查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Wl admin_Wl = new Admin_Wl();
            admin_Wl.Show();
            admin_Wl.MdiParent = this;
        }

        private void 设备监控ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Admin_Monitor admin_Monitor = new Admin_Monitor();
                admin_Monitor.Show();
                admin_Monitor.MdiParent = this;
        }

        private void 参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_CsSet admin_CsSet = new Admin_CsSet();
            admin_CsSet.Show();
            admin_CsSet.MdiParent = this;
        }

        private void 设备操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_SbOp admin_SbOp = new Admin_SbOp();
            admin_SbOp.Show();
            admin_SbOp.MdiParent = this;
        }

        private void 库存管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Kc admin_Kc = new Admin_Kc();
            admin_Kc.Show();
            admin_Kc.MdiParent = this;
        }

        private void 订单查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_SearchOrder admin_SearchOrder = new Admin_SearchOrder();
            admin_SearchOrder.Show();
            admin_SearchOrder.MdiParent = this;
        }
    }
}
