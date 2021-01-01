using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecondWebApplication.Controls
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ユーザーコントロールのプロパティをWebフォームから取得
            Label1.Text =
                string.Format("{0}時{1}分 「{2}」という内容のスケジュールを登録します",
                              TestControl1.Hour,
                              TestControl1.Minute,
                              ScheduleTextBox.Text); 
        }
    }
}