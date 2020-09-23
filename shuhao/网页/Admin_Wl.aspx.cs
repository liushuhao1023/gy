using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace part4
{
    public partial class Admin_Wl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Data.UTP == "admin")
            {
                Response.Redirect("Admin_Main.aspx");
            }
            else if (Data.UTP == "op")
            {
                Response.Redirect("Op_Main.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "update lc set mid='" + this.DropDownList2.SelectedValue.Trim() + "',num='" + this.TextBox1.Text + "' where id='" + this.DropDownList1.SelectedValue.Trim() + "'";
            SBS.DBOP.exsql(sql);
            GridView1.DataBind();
        }
    }
}