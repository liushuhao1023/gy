using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace part4
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Data.UTP = "admin";
            SBS.JsHelper.Redirect("Admin_Main.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Data.UTP = "op";
            SBS.JsHelper.Redirect("Op_Main.aspx");
        }
    }
}