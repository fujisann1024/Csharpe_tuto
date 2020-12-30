Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'メッセージ表示用ラベルに選択内容を出力していく
        Label1.Text = "<ul>"


        '複数選択のListBoxコントロールの選択項目の取得 
        'VB.NETの変数宣言(Dim 変数名 As データ型)
        Dim selectedItemText As String = ""
        'VB.NETのforeach文()
        For Each item In ListBox1.Items
            '選択されていればTextプロパティを取得
            If (item.Selected) Then
                selectedItemText += item.Text + " "

            End If

        Next


        'ListBoxコントロールの内容を表示
        Label1.Text += String.Format(
            "<li>ListBoxコントロールでは{0}が選択されています</li>", selectedItemText)


        'DropDownListコントロールの選択項目の取得
        Label1.Text += String.Format(
            "<li>DropDownListコントロールではテキストが{0},値が{1}のListItemが選択されています</li>",
            DropDownList1.SelectedItem.Text,
            DropDownList1.SelectedValue
            )


        'CheckBoxListコントロールの選択項目の取得
        Dim selectedCheckBoxText As String = ""
        For Each item In CheckBoxList1.Items
            '選択されていればTextプロパティを取得
            If (item.Selected) Then
                selectedCheckBoxText += item.Text + ""

            End If
        Next

        Label1.Text += String.Format(
            "<li>CheckBoxListコントロールでは{0}が選択されています</li>",
            selectedCheckBoxText
        )


        'CheckBoxListコントロールの選択内容を表示
        '変数 != null ＝　VB.NET 変数　IsNot Nothing
        If (RadioButtonList1.SelectedItem IsNot Nothing) Then
            Label1.Text += String.Format(
            "<li>RadioButtonListコントロールではテキストが{0},値が{1}のListItemが選択されています</li>",
              RadioButtonList1.SelectedItem.Text,
              RadioButtonList1.SelectedValue)
            Label1.Text += "</ul>"


        End If






    End Sub
End Class