using Opc.Ua;
using Opc.Ua.Client;
using OpcUaHelper;
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
    public partial class Admin_Monitor : Form
    {
        public Admin_Monitor()
        {
            InitializeComponent();
        }

        OpcUaClient Client = new OpcUaClient();
        string str = "Data Source=.;Initial Catalog=exam1;Integrated Security=True";

        public void exsql(string sql)
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        string[] scjk = new string[]
        {
            "ns=2;s=数据类型示例.16 位设备.R 寄存器.DWord4",
            "ns=2;s=数据类型示例.16 位设备.R 寄存器.DWord3",
            "ns=2;s=数据类型示例.16 位设备.R 寄存器.DWord2",
            "ns=2;s=数据类型示例.16 位设备.R 寄存器.DWord1",
        };
        public void SubCallback(string key, MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs args)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, MonitoredItem, MonitoredItemNotificationEventArgs>(SubCallback), key, monitoredItem, args);
                return;
            }
            if (key == "B")
            {
                MonitoredItemNotification notification = args.NotificationValue as MonitoredItemNotification;
                for (int i = 0; i < 4; i++)
                {
                    if (monitoredItem.StartNodeId.ToString() == scjk[i])
                    {
                        string sql = "update sb set status='" + notification.Value.WrappedValue.Value.ToString().Trim() + "'where id='" + (i + 1).ToString() + "'";
                        exsql(sql);
                    }
                }
            }
        }

        private async void Admin_Monitor_Load(object sender, EventArgs e)
        {
            try
            {
                await Client.ConnectServer("opc.tcp://127.0.0.1:49320");
                Client.AddSubscription("B",scjk,SubCallback);
                Info_Table();
            }
            catch (Exception)
            {

                throw;
            }
          
        }
        public void Info_Table()
        {
            dataGridView1.Rows.Clear();
            string str = "Data Source=.;Initial Catalog=exam1;Integrated Security=True";
            string sql = "select * from sb ";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            IDataReader dc = cmd.ExecuteReader();
            while (dc.Read())
            {
                string id = dc[0].ToString();
                string name = dc[1].ToString();
                string status = dc[2].ToString();
                dataGridView1.Rows.Add(id, name, status);
            }
            dc.Close();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Info_Table();
        }

        private void Admin_Monitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Admin_Monitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Client.RemoveSubscription("B");
            Client.Disconnect();
        }
    }
}
