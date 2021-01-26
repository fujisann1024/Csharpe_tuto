using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVP.Project.View
{
    public partial class LoginCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkEmail.Text = HttpUtility.HtmlEncode(Session["Email"]);
            checkPassword.Text = HttpUtility.HtmlEncode(Session["Password"]);
        }
    }
}