using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace part4
{
    public partial class LC : System.Web.UI.Page
    {
        public static string safeqty = "2";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            safeqty = this.TextBox1.Text;
            this.Label1.Text = safeqty;
        }
    }
}