using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecondWebApplication
{
    public partial class GirdViewSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //SelectedIndexChangedイベント

        //GridViewイベント
        /*
         RowInserted～レコードの新規登録完了後に発生
         RowUpdated ～レコードの更新完了後に発生
         RowDeleted ～レコードの削除完了後に発生
         RowCommand ～GridViewコントロール内でコマンド付きのボタンがクリックされた場合
                      に発生
         SelectedIndexChanged
                    ～レコードが選択された場合に発生
         Sorting    ～ソート実行前に発生
         */
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SelectedValueプロパティで選択されたレコードの主キーを取得する
            var employeeId = GridView1.SelectedValue;
            //単票画面に遷移
            Response.Redirect(string.Format(
                "~/Form/GirdViewSample.aspx?EmployeeId={0}",employeeId));
        }

        //RowCommandイベントハンドラー
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //コマンド名を確認
            if (e.CommandName == "Custom")
            {
                //第二引数のCommandArgumentプロパティから、押されたボタンの行数を取得

                int rowNumber = int.Parse(e.CommandArgument.ToString());

                //ボタンが押された行の3番目のセルの背景色を赤に指定
                GridView1.Rows[rowNumber].Cells[2].BackColor = System.Drawing.Color.Red;
            }
        }
    }
}