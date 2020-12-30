Public Class TestForm4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Command(sender As Object, e As CommandEventArgs)
        'コマンド名で場合分け
        'VB.NETのswitch文
        'Select Case 変数
        '   Case 値
        '       Trueだった時の処理
        '       :
        'End Select
        Select Case e.CommandName
            Case "Edit"
                Label2.Text = "編集画面へ移行します"
            Case "Sort"

                'さらにコマンド引数で場合分け
                Select Case e.CommandArgument.ToString()
                    Case "Asc"
                        Label2.Text = "昇順ソートを行います"
                    Case "Desc"
                        Label2.Text = "降順ソートを行います"
                End Select

        End Select


    End Sub
End Class