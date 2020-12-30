using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecondWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
             ポストバック後にFileUpLoadコントロールで使用可能なプロパティ
                HasFile～ファイルがアップロードされたか
                PostedFile～アップロードされたファイル
             */
            //ファイルがアップロードされていれば 
            if (FileUpload1.HasFile)
            {
                var file = FileUpload1.PostedFile;//HttpPostedFileインスタンスの取得
                /*
               HttpPostedFileクラスの主なプロパティとメソッド
                    FileNameプロパティ～ファイル名
                    ContentLengthプロパティ～ファイルサイズ
                    ContentTypeプロパティ～ファイルの種類
                    InputStreamプロパティ～ファイルの内容
                    SaveAsメソッド～アップロードされたファイルに名前を付けて保存
                 */

                Label1.Text = "アップロードされたファイルの情報<br/>";
                Label1.Text += string.Format("ファイル名: {0}<br/>",file.FileName);
                Label1.Text += string.Format("ファイルサイズ: {0}バイト<br/>",file.ContentLength);
                Label1.Text += string.Format("コンテントタイプ: {0}<br/>",file.ContentType);
                Label1.Text += string.Format("アップロードされたファイルを一時フォルダに保存する");
                //System.IO.Path.GetTempPath()～一時フォルダを取得するメソッド
                //System.IO.Path.GetFileName()～フルパスからファイル名を取得するメソッド
                file.SaveAs(
                    System.IO.Path.GetTempPath() +              //一時フォルダ
                    System.IO.Path.GetFileName(file.FileName)   //ファイル名
                    );
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //AllowMulti～複数ファイルアップロードを受け付けるかどうか
            //HasFiles～ファイルをアップロードされているかどうか
            //PostedFiles～アップロードされたファイルのコレクション
            if (FileUpload2.HasFiles)
            {
                foreach (var file in FileUpload2.PostedFiles)
                {
                    Label2.Text += "アップロードされたファイルの情報";
                    Label2.Text += string.Format("ファイル名:{0}<br/>",file.FileName);
                    Label2.Text += string.Format(" ファイルサイズ:{0}<br/>",file.ContentLength);
                    Label2.Text += string.Format("コンテントタイプ:{0}<br/>",file.ContentType);
                    file.SaveAs(
                        System.IO.Path.GetTempPath() +              //一時フォルダ
                        System.IO.Path.GetFileName(file.FileName)   //ファイル名
                        );
                }
            }
        }
    }
}