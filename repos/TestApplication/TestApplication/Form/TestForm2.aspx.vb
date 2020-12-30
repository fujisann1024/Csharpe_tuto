Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ポストバック
        Label1.Text = "TextBoxのコントロールの値が「" + TextBox1.Text + "」に変更されました"
        '自動ポストバック
        Label2.Text = "TextAreaのコントロールの値が「" + TextBox2.Text + "」に変更されました"

    End Sub


    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'チェックボックス
        'VB.NETのif文
        'If(条件式) Then
        '   条件式がTrueの場合の処理
        'Else If(条件式) Then
        '   条件式がTrueの場合の処理
        'Else
        '   条件式がFalseの場合の処理
        'End If
        If (CheckBox1.Checked) Then
            Label3.Text = "チェックボックスはチェックされています"
        Else
            Label3.Text = "チェックボックスはチェックされていません"
        End If

        'ラジオボタン
        If (RadioButton1.Checked) Then
            Label4.Text = "ラジオボタンはテレビが選択されています"
        End If

        If (RadioButton2.Checked) Then
            Label4.Text = "ラジオボタンは新聞が選択されています"
        End If

        If (RadioButton3.Checked) Then
            Label4.Text = "ラジオボタンはWebが選択されています"
        End If



    End Sub
End Class