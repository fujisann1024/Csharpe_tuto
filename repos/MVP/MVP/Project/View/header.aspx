<%@ Page Title="" Language="C#" MasterPageFile="~/Project/View/Sample.Master" AutoEventWireup="true" CodeBehind="header.aspx.cs" Inherits="MVP.Project.View.header" %>
<%--MasterPageFile属性～この属性で参照するマスターページを表す--%>
<%--Contentsコントロール～マスターページに埋め込むためのコンテンツを記述するためのコントロール--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="コンテンツページのコンテンツ"></asp:Label>
</asp:Content>
