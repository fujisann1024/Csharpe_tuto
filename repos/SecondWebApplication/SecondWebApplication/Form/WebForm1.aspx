<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SecondWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <!--ファイルアップロードを使用する-->
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="アップロードされたファイルの情報"></asp:Label><br />
            <asp:FileUpload ID="FileUpload1" runat="server" /><br />

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="アップロード"/>
        </div>
        <!--複数のファイルをアップロードする
            
            -->
        <div>
            <asp:Label ID ="Label2" runat="server" Text=""></asp:Label><br />
            <asp:FileUpload ID="FileUpload2" runat="server" AllowMultiple="true"/><br />
            <asp:Button ID="Button2" runat="server" Text="複数アップロード" OnClick="Button2_Click"/>
        </div>
    </form>
</body>
</html>
