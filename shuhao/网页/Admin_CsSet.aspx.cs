using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace part4
{
    public partial class Admin_CsSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into cp(lx,pm1,pm2,color)values('" + this.TextBox1.Text + "','" + this.DropDownList1.SelectedValue.Trim() + "','" + this.DropDownList2.SelectedValue.Trim() + "','" + this.TextBox2.Text + "')";
            SBS.DBOP.exsql(sql);
            GridView1.DataBind();
        }
    }
}