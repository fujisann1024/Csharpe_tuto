<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="WebForm1.aspx.cs" 
    Inherits="MVP.Project.View.WebForm1"
    Trace ="true"
    %>
<%--
    @Pageディレクティブ ～ Webページの設定を行う
    Language属性 ～ このページで使用する言語
    CodeBehind,Inherits属性 ～ 指定したファイルとコードビハインドクラスの関連付けを行う
           コードビハインド: デザイナーが担当するaspxファイルとプログラマー側が担当するaspx.csファイル
    　　　　　　　　　　　　 に別々に分類すること
    AutoEventWireup属性 ～ イベントハンドラーとの関連付けを自動的に行うかどうか
    Trace属性 ～ 処理内容のトレースを行うための属性
    --%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="emailTitle" runat="server">メールアドレス</asp:Label><br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox><br />
            <asp:Label ID="" runat="server" Visible="false" CssClass="error"></asp:Label>
        </div>
        <div>
            <asp:Label ID="passwordTitle" runat="server">パスワード</asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Visible="false" CssClass="error"></asp:Label>
        </div>
    </form>
</body>
</html>
