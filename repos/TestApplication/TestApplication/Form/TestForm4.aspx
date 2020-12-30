<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TestForm4.aspx.vb" Inherits="TestApplication.TestForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <!--ボタンを使用する-->
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
            <!--inputタグ(type=submit)-->
            <asp:Button ID="Button1" runat="server" Text="Button"/><br />

            <!--aタグ-->
            <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton><br />

            <!--inputタグ(type=image)-->
            <asp:ImageButton ID="ImageButton1" runat="server"
                ImageUrl="http://www.wings.msn.to/image/wings.jpg"
                ImageAlign="Middle"/>
        </div>

        <div>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />

            <asp:Button ID="Button2" runat="server" Text="編集"
                CommandName="Edit" OnCommand="Button2_Command"/><br />

            <asp:Button ID="SortButton1" runat="server" 
                CommandArgument="Asc" CommandName="Sort" OnCommand="Button2_Command"
                Text="並び替え(昇順)"/>

            <asp:Button ID="SortButton2" runat="server"
                CommandArgument="Desc" CommandName="Sort" OnCommand="Button2_Command"
                Text="並び替え(降順)"/>

        </div>
    </form>
</body>
</html>
