<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TestForm3.aspx.vb" Inherits="TestApplication.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <!--
    　ListItemクラスのプロパティ
        Enabled～選択項目の有効/無効の指定
        Selected～選択項目が選択されているかどうか
        Text～選択項目のテキスト
        Value～選択項目の値
        -->
    <form id="form3" runat="server">
        <!--
            Items～選択項目のコレクション
            Rows～リストボックスの行数＞選択項目よりも少ない場合はスクロールバーが表示される
            SelectionMode～リストボックスの選択モード。1つだけ選択可能なSingleと、複数選択
                           可能なMultipleがある。デフォルトはSingle
            -->
        <asp:Label ID="Label1" runat="server" Text="メッセージ表示用ラベル"></asp:Label><br />
        <div>
            <!--selectタグ (size属性あり)-->
            <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
                <asp:ListItem Value="meat">肉</asp:ListItem>
                <asp:ListItem Value="fish">魚</asp:ListItem>
                <asp:ListItem Value="vegetable">野菜</asp:ListItem>
                <asp:ListItem Value="rice">米</asp:ListItem>
            </asp:ListBox>
        </div>
        <div>
            <!--selectタグ (size属性なし)-->
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="japanese">和食</asp:ListItem>
                <asp:ListItem Value="french">フランス料理</asp:ListItem>
                <asp:ListItem Value="german">ドイツ料理</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <!--inputタグ(type属性はcheckbox)複数-->
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem Value="sports">スポーツ</asp:ListItem>
                <asp:ListItem Value="music">音楽</asp:ListItem>
                <asp:ListItem Value="sports">映画</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div>
            <!--inputタグ(type属性はradio)複数-->
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Value="student">生徒</asp:ListItem>
                <asp:ListItem Value="business">会社員</asp:ListItem>
                <asp:ListItem Value="executive">経営者</asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="送信"/>
    </form>
</body>
</html>
