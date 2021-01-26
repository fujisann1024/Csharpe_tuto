<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Login.aspx.cs" 
    Inherits="MVP.Project.View.Login"
    Trace="true"
    %>
<%--
     @Pageディレクティブ ～ Webページの設定を行う
    Language属性 ～ このページで使用する言語
    CodeBehind,Inherits属性 ～ 指定したファイルとコードビハインドクラスの関連付けを行う
           コードビハインド: デザイナーが担当するaspxファイルとプログラマー側が担当するaspx.csファイル
    　　　　　　　　　　　　 に別々に分類すること
    AutoEventWireup属性 ～ イベントハンドラーとの関連付けを自動的に行うかどうか
    Trace属性 ～
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
            <div>
                <asp:Label ID="httpInfo" runat="server"></asp:Label>
            </div>
            <div>
                <asp:Label ID="emailTitle" runat="server">メールアドレス</asp:Label><br />
                <asp:TextBox ID="email" runat="server">
                </asp:TextBox><br />
                <asp:Label ID="emailError" runat="server" Visible="false" CssClass="error"></asp:Label>
            </div>
            <div>
                <asp:Label ID="passwordTitle" runat="server">パスワード</asp:Label><br />
                <asp:TextBox ID="password" runat="server" TextMode="Password">
                </asp:TextBox><br />
                <asp:Label ID="passwordError" runat="server" Visible="false" CssClass="error"></asp:Label>
            </div>
            <asp:Button ID="loginButton" runat="server" Text="ログイン" OnClick="loginButton_Click"/>
        </div>

        <div>

            <div>
                <asp:Label ID="emailCookie" runat="server">メールアドレス(Cookie)</asp:Label>
                <asp:Label ID="passwordCookie" runat="server">パスワード(Cookie)</asp:Label>
            </div>
        </div>

        <div>　
            <asp:Button ID="Check_Login" runat="server" Text="確認画面へ移動" OnClick="checkButton_Click"/>
        </div>
    </form>
</body>
</html>
