using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using OpcUaHelper;
using Opc.Ua;
using Opc.Ua.Client;

namespace _0921Api
{
    public class function
    {
        public static SqlCommand cmd = null;
        public static SqlConnection conn = null;
        public static string sql = null;

        public static string matId;

        public static string storePos;
        public static string num;
        public static string orderId;
        public static string type;
        public static string color;

        public static bool firstOrder = true;

        public static OpcUaClient opcUaClient = new OpcUaClient();
        public static void openDatabase()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=0920;Persist Security Info=True;User ID=sa;Password=123456";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static void execute(string sql)
        {
            openDatabase();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static string getBin(string matId)
        {
            openDatabase();
            cmd = new SqlCommand("select id from bins where matId="+ matId + "", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                var info = dr[0].ToString().Trim();
                conn.Close();
                return info;
            }
            else
            {
                conn.Close();
                return null;
            }
        }

        public void subCallback(string key,MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs args)
        {
            if(key == "A")
            {
                MonitoredItemNotification notification = args.NotificationValue as MonitoredItemNotification;
                if(notification != null)
                {
                    if(notification.Value.WrappedValue.Value.ToString() == "False")
                    {
                        sendOrder(matId,storePos,num,orderId,type,color);
                    }
                }
            }
        }

        public static void sendOrder(string matId,string storePos, string num,string orderId,string type,string color)
        {
            try
            {
                var id = getBin(matId);
                var date = DateTime.Now.ToString("MMdd");
                var time = DateTime.Now.ToString("HHmm");
                if (id != null)
                {
                    opcUaClient.ConnectServer("opc.tcp://172.21.1.6:4840");
                    opcUaClient.WriteNodes(
                        new string[] 
                        {
                            "ns=3;s=\"KB7\"",
                            "ns=3;s=\"KB12\""
                        },
                        new object[] 
                        { 
                            Byte.Parse(id),
                            Byte.Parse(num),
                            //type[0].ToString(),
                            //type[1].ToString(),
                            //type[2].ToString(),
                            //type[3].ToString(),
                            //orderId[0].ToString(),
                            //orderId[1].ToString(),
                            //orderId[2].ToString(),
                            //orderId[3].ToString(),
                            //date[0].ToString(),
                            //date[1].ToString(),
                            //date[2].ToString(),
                            //date[3].ToString(),
                            //time[0].ToString(),
                            //time[1].ToString(),
                            //time[2].ToString(),
                            //time[3].ToString(),
                            //color[0].ToString(),
                            //color[1].ToString(),
                            //color[2].ToString(),
                            //color[3].ToString(),
                        }
                     );
                    opcUaClient.Disconnect();
                    sql = "update orders set beginTime = '" + DateTime.Now.ToString("MMdd") + "', status ='进行中' where orderId = '" + orderId + "'";
                    execute(sql);
                }
            }
            catch (Exception)
            {

                
            }
        }

    }
}
