<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Http.aspx.cs" Inherits="MVP.Project.View.Http" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:Label ID="httpInfo" runat="server"></asp:Label><br />
           <asp:HyperLink ID="movePage" runat="server" 
                          NavigateUrl="~/Project/View/Login.aspx?key1=login&key2=regist" Text="ログイン画面へ">
           </asp:HyperLink>
           <asp:Button ID="httpButton" runat="server" Text="ログイン画面へ" OnClick="Info_Click"/>
        </div>
    </form>
</body>
</html>
