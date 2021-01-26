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

            if (Request.Cookies["emailCookie"] != null && Request.Cookies["passwordCookie"] != null)
            {
                //Cookies～クッキーの取得
                emailCookie.Text = Request.Cookies["emailCookie"].Value;
                passwordCookie.Text = Request.Cookies["passwordCookie"].Value;

            }else
            {
                Response.Cookies["emailCookie"].Value = email.Text;
                Response.Cookies["passwordCookie"].Value = password.Text;
                //Cookieの有効期間を保存
                Response.Cookies["emailCookie"].Expires = DateTime.Now.AddDays(10);
                Response.Cookies["passwordCookie"].Expires = DateTime.Now.AddDays(10);
            }
        }

        protected void checkButton_Click(object sender, EventArgs e)
        {
            //セッションに入力データを保存
            Session["Email"] = email.Text;
            Session["Password"] = password.Text;

            //次のページにリダイレクト
            Response.Redirect("/Project/View/LoginCheck.aspx");
        }
    }
}