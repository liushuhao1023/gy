using OpcUaHelper;
using System;
using System.Windows.Forms;

namespace winform_test1
{
    public partial class Admin_SbOp : Form
    {
        public Admin_SbOp()
        {
            InitializeComponent();
        }
        OpcUaClient Client = new OpcUaClient();
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.label2.Text = "手动";
                await Client.ConnectServer("");
                Client.WriteNode<Boolean>("", true);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.label2.Text = "自动";
                await Client.ConnectServer("");
                Client.WriteNode<Boolean>("", true);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                await Client.ConnectServer("");
                Client.WriteNode<Boolean>("", true);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                await Client.ConnectServer("");
                Client.WriteNode<Boolean>("", true);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
             try
            {
                await Client.ConnectServer("");
                Client.WriteNode<Boolean>("", true);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Admin_SbOp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Client.Disconnect();
        }
    }
}
