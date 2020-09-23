using OpcUaHelper;
using System;
using System.Data;
using System.Web.Http;

namespace part2.Controllers
{
    public class Part2Controller : ApiController
    {

        public static int i = 0;
        public static string pm1 = "";
        public static string pm2 = "";
        public static string qty = "";
        public static string msg = "D00" + (i + 1).ToString();
        public static string wz1 = "";
        public static string wz2 = "";
        public static string lx = "";
        public static string adress = "";
        public static string color = "";

        OpcUaClient Client = new OpcUaClient();


        public class T_User
        {
            public string Userid { get; set; }
            public string Pwd { get; set; }
            public string Address { get; set; }
            public Boolean Suborder { get; set; }
            public Boolean Search { get; set; }
            public DateTime Logintime { get; set; }
        }
        public class T_Order
        {
            public string orderid { get; set; }
            public string lx { get; set; }
            public string qty { get; set; }
            public string fqty { get; set; }
            public string otime { get; set; }
            public string status { get; set; }
        }

        public class Cp
        {
            public string lx { get; set; }
            public string pm1 { get; set; }
            public string pm2 { get; set; }
            public string color { get; set; }

        }

        [Route("user/reg")]
        [HttpGet]
        public string UserReg(string userid,string pwd,string address)
        {
            try
            {
                string sql = "insert into t_user(userid,pwd,[address],suborder,searchorder)values('" + userid + "','" + pwd + "','" + address + "','true','true')";
                SBS.DBOP.exsql(sql);
                return "1";
            }
            catch (Exception)
            {

                return "0";
            }
        }

        [Route("user/login")]
        [HttpGet]
        public T_User GetT_User(string userid)
        {
            DataTable table = new DataTable();
            string sql = "select * from t_user where userid='" + userid + "'";
            table = SBS.DBOP.GetDataTable(sql);
            T_User t_User = new T_User();
            t_User.Userid = table.Rows[0]["userid"].ToString().Trim();
            Data.UID= table.Rows[0]["userid"].ToString().Trim();
            t_User.Pwd = table.Rows[0]["pwd"].ToString().Trim();
            t_User.Address = table.Rows[0]["address"].ToString().Trim();
            Data.ADDR= table.Rows[0]["address"].ToString().Trim();
            string sql1 = "update t_user set logintime='"+DateTime.Now+ "'where userid='" + userid + "' ";
            SBS.DBOP.exsql(sql1);
            return t_User;
        }

        [Route("order/sub")]
        [HttpGet]
        public string SubOrder(string lx, string qty)
        {
            try
            {
                Client.ConnectServer("opc.tcp://172.21.1.6:4840");
                string sql1 = "insert into t_order(userid,[address],lx,qty,otime,status) values('"+Data.UID+ "','" + Data.ADDR + "','" + lx + "','" + qty + "','"+DateTime.Now+"','待启动')";
                SBS.DBOP.exsql(sql1);
                Client.WriteNode<byte>("ns=3;s=\"下单\".\"KB7\"["+i+"]", byte.Parse(lx));
                Client.WriteNode<byte>("ns=3;s=\"下单\".\"KB12\"["+i+"]", byte.Parse(qty));
                Client.WriteNode<string>("ns=3;s=\"下单\".\"11\"[" + i + "]", msg);
                i++;

                return "1";
            }
            catch (Exception)
            {

                return "0";
            }


        }

        [Route("order/search")]
        [HttpGet]
        public T_Order[] GetT_User()
        {
            string sql = "select orderid,lx,qty,fqty,otime,status from t_order where userid='" + Data.UID + "'";
            DataTable dataTable = SBS.DBOP.GetDataTable(sql);
            T_Order[] orders = new T_Order[dataTable.Rows.Count];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                orders[i] = new T_Order
                {
                    orderid = dataTable.Rows[i]["orderid"].ToString().Trim(),
                    lx = dataTable.Rows[i]["lx"].ToString().Trim(),
                    qty = dataTable.Rows[i]["qty"].ToString().Trim(),
                    fqty = dataTable.Rows[i]["fqty"].ToString().Trim(),
                    otime = dataTable.Rows[i]["otime"].ToString().Trim(),
                    status = dataTable.Rows[i]["status"].ToString().Trim(),
                };
            }
            return orders;
        }

        [Route("product/read-all")]
        [HttpGet]

        public Cp[] GetProduct()
        {
            DataTable table = new DataTable();
            string sql = "select * from cp";
            table = SBS.DBOP.GetDataTable(sql);

            Cp[] cp = new Cp[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                cp[i] = new Cp
                {
                    lx = table.Rows[i]["lx"].ToString().Trim(),
                    pm1 = table.Rows[i]["pm1"].ToString().Trim(),
                    pm2 = table.Rows[i]["pm2"].ToString().Trim(),
                    color = table.Rows[i]["color"].ToString().Trim(),
                };
            }
            return cp;
        }
    }
}
