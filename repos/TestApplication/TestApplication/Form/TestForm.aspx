<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TestForm.aspx.vb" Inherits="TestApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <!--onclickイベントを追加する-->
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>

  <!--表示用コントロールの使用-->
    <!--Labelコントロールはspanタグとして表示-->
    <asp:Label ID="Label2" runat="server" Text="Label2コントロールの表示テキスト"></asp:Label>
    <!--Literalコントロールはタグ付けなしでそのまま表示されるだけ-->
    <asp:Literal ID="Litelal2" runat="server" Text="Litelal2コントロールの表示テキスト"></asp:Literal>
    <!--画像を表示する
        ImageURL～画像のＵＲＬ
        AlternateText～画像の代替テキスト
        DescriptionUrl～画像を説明するページのＵＲＬ
        ImageAlign～画像の位置の指定
        -->
    <br />
    <asp:Image ID="Image1" runat="server" AlternateText="代替テキスト" ImageURL="#"
        ImageAlign="Middle"/>
    <!--リンクを表示する-->
    <!--
        NavigateUrl～リンク先のＵＲＬ
        ImageUrl～表示する画像のＵＲＬ
        Target～リンク先を表示するウィンドウ
        Text～表示するテキスト
        -->
    <!--aタグ-->
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="#" ImageUrl="#" Text="リンク先"></asp:HyperLink>
    <!--例外の詳細: System.Web.HttpException: 1 つのページには、1 つのサーバー側 Form タグのみを指定できます。-->
   <!-- <form id ="form2" runat="server">
        
    </form>-->
    
</body>
</html>
