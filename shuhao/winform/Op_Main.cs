using System;
using System.Windows.Forms;

namespace winform_test1
{
    public partial class Op_Main : Form
    {
        public Op_Main()
        {
            InitializeComponent();
        }

        private void 设备操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_SbOp admin_SbOp = new Admin_SbOp();
            admin_SbOp.Show();
            admin_SbOp.MdiParent = this;
        }

        private void 参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_CsSet admin_CsSet = new Admin_CsSet();
            admin_CsSet.Show();
            admin_CsSet.MdiParent = this;
        }
    }
}
