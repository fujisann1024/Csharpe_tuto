<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TestForm2.aspx.vb" Inherits="TestApplication.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
      <!--入力用コントロールの使用-->
    <!--
        TextMode～入力モードの切り替え
        Columns～表示幅の指定
        MaxLength～入力可能な最大文字数の指定
        ReadOnly～内容を変更可能か
        Text～テキストボックスのテキスト
        Rows～行数の指定
        Wrap～テキストを右端で表示するかどうかの指定
        -->
    <!--フォームタグの中に入れないとエラーになる
        idはページによって変える-->
    <form id="form2" runat="server">
        <asp:Label ID="Label2" runat="server" Text="内容"></asp:Label><br />
        <!--inputタグ (type=text)-->
        <asp:TextBox ID="TextBox1" runat="server" Columns="30" MaxLength="30" Text="テキストを入力して下さい"
            ></asp:TextBox>SingleLine<br />
        <!--textareaタグ-->
        <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Rows="8"></asp:TextBox>MultiLine<br />
        <!--inputタグ (type=password)-->
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Columns="8" MaxLength="8"></asp:TextBox>Password<br />
        <!--ポストバック用のButtonコントロール-->
        <asp:Button ID="Button2" runat="server" Text="Button" />
    </form>
</body>
</html>
