using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecondWebApplication.Form
{
    public partial class CheckForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ページ全体の検証が成功しているかどうか
            if (Page.IsValid)
            {
                //検証成功時の処理
                ResultLabel.Text = "検証成功です";
            }
            else
            {
                //検証失敗時の処理
                ResultLabel.Text = "検証失敗です";
            }
        }
    }
}