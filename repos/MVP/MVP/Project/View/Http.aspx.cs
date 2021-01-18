using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVP.Project.View
{
    public partial class Http : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Info_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Project/View/Login.aspx");
        }
    }
}