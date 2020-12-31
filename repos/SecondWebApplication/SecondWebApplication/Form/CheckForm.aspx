<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckForm.aspx.cs" Inherits="SecondWebApplication.Form.CheckForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <!--
        検証コントロールの種類と機能
            RequiredFieldValidator～入力必須項目を検証する
            RangeValidator～入力範囲を検証する
            CompareValidator～入力内容を比較して検証する
            RegularExpressionValidator～入力内容を正規表現で検証する
            CustomValidator～独自の方法で検証する
            ValidationSummary～検証結果のエラーメッセージをまとめて表示する
            -->

        <!--
          検証コントロールの主な共通プロパティ
            ControlToValidate       ～検証対象となるコントロールを指定する
            Display                ～エラーメッセージを検証コントロールで表示するか
            EnableClientScript     ～WebブラウザーでのJavaScriptによる検証を行うかどうか
            Enabled                ～検証コントロールの有効、無効を設定する
            ErrorMessage           ～検証エラー時に検証コントロールで表示するメッセージを指定する
            Text                   ～検証エラー時に検証コントロールで表示するメッセージを指定する
            IsValid                ～検証が成功したかどうかを取得。設定する
            SetFocusOnError        ～検証失敗時に検証対象コントロールにフォーカスを移動するかどうか
            ValidationGroup        ～この検証コントロールの属する検証グループを指定する
            -->
        <div>
            <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <!--Javascriptによる検証機能を持つためエラーが起きた時はポストバックは行われない-->
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ErrorMessage="テキストを入力して下さい"
                ControlToValidate="TextBox1">
            </asp:RequiredFieldValidator><br />

            <asp:Button ID="Button1" runat="server" Text="送信" OnClick="Button1_Click"/>
        </div>

        <div>
            <asp:Label ID="ResultLabel2" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"
                Text="テキストを入力して下さい" Columns="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                runat="server" ErrorMessage="初期値から値を変更してください" ControlToValidate="TextBox2"
                InitialValue="テキストを入力して下さい">
            </asp:RequiredFieldValidator><br />

            <asp:Button ID="Button2" runat="server" Text="送信"/>
        </div>

        <!--
            MinimumValue～入力範囲の最小値
            MaximumValue～入力範囲の最大値
            Type～入力値のデータ型
            -->
        <div>
            年齢<asp:TextBox ID="Age" runat="server" Text=""></asp:TextBox><br />
            <asp:RangeValidator ID="RangeValidator1" runat="server"
                ControlToValidate="Age" ErrorMessage="年齢は0－150歳以上の範囲で入力して下さい"
                MaximumValue="150" Type="Integer" MinimumValue="0"></asp:RangeValidator>
            <br />
            生年月日<asp:TextBox ID="BirthDay" runat="server" Text=""></asp:TextBox><br />
            <asp:RangeValidator ID="RangeValidator2" runat="server"
                ControlToValidate="Birthday" Type="Date"
                ErrorMessage="誕生日は1985年以降を指定してください"
                MinimumValue="1850/1/1" MaximumValue="9999/1/1"></asp:RangeValidator>
            <asp:Button ID="Button3" runat="server" Text="送信"/>
        </div>
    </form>
</body>
</html>
