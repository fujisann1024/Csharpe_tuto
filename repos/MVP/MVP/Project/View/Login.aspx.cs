using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVP.Project.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string HttpInfo = "<ul><li>";
            HttpInfo += Request.QueryString["key1"] + "</li><li>";
            HttpInfo += Request.QueryString["key2"] + "</li>";
            HttpInfo += "</ul>";
            httpInfo.Text = HttpInfo;
        }

        //クリックイベント
        protected void loginButton_Click(object sender, EventArgs e)
        {
            //Traceオブジェクト
            Trace.Write(string.Format("emailに入力された文字列は{0}です",email.Text));
            Trace.Warn(string.Format("passwordに入力された文字列は{0}です",password.Text));
        }
    }
}