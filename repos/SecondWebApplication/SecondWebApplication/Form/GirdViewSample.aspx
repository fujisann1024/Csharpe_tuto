<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GirdViewSample.aspx.cs" Inherits="SecondWebApplication.GirdViewSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--PageSize～1ページ当たりの行数
                ViewStateMode～ビューステートの無効化-->

            <!--GridViewコントロールの編集に利用可能なクラス
                BoundField       ～文字列を出力する
                HyperLinkField   ～リンクを出力する
                ImageField       ～画像を出力する
                CheckBoxField    ～チェックボックスを出力する
                CommandField     ～コマンド付きのボタンを出力する
                ButtonField      ～ボタンを出力する
                TemplateField    ～テンプレートに基づく内容を出力する
                -->
            <asp:GridView ID="GridView1" runat="server" 
                AutoGenerateColumns="False" 
                CellPadding="4" 
                DataKeyNames="EmployeeId" 
                DataSourceID="SqlDataSource1" 
                ForeColor="#333333" 
                GridLines="None" 
                AllowPaging="True" 
                AllowSorting="True"
                PageSize="5"
                ViewStateMode="Disabled" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="EmployeeId" DataNavigateUrlFormatString="~/Form/GridViewSample.aspx?EmployeeId={0}" Text="詳細" />
                    <asp:BoundField DataField="EmployeeId" HeaderText="社員ID" ReadOnly="True" SortExpression="EmployeeId" />
                    <asp:BoundField DataField="Name" HeaderText="氏名" SortExpression="Name" />
                    <asp:TemplateField HeaderText="課" SortExpression="DepartmentId">                        
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("DepartmentName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Birthday" HeaderText="誕生日" SortExpression="Birthday" DataFormatString="{0:yyyy/MM/dd}" />
                    <asp:BoundField DataField="Sales" HeaderText="当期売上高" SortExpression="Sales" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="TelNo" HeaderText="電話番号" SortExpression="TelNo" />
                    <asp:CheckBoxField DataField="Sex" HeaderText="性別" SortExpression="Sex" />
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:ButtonField ButtonType="Button" CommandName="Custom" Text="カスタム"/>
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <!--式ビルダー
                AppSettings～アプリケーション構成ファイルのappSetting要素で設定したアプリケーション設定
                ConnectionStrings～アプリケーション構成ファイルのconnectionStrings要素で設定した接続文字列
                Resource～リソースファイルのリソース-->
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                DeleteCommand="DELETE FROM [Employees] WHERE [EmployeeId] = @EmployeeId" 
                InsertCommand="INSERT INTO [Employees] ([EmployeeId], [Name], [DepartmentId], [Birthday], [Sales], [TelNo], [Sex]) VALUES (@EmployeeId, @Name, @DepartmentId, @Birthday, @Sales, @TelNo, @Sex)"
                SelectCommand="SELECT Departments.Name AS DepartmentName, Employees.* FROM Departments
                               INNER JOIN Employees ON Departments.DepartmentId = Employees.DepartmentId" 
                UpdateCommand="UPDATE [Employees] SET [Name] = @Name, [DepartmentId] = @DepartmentId, [Birthday] = @Birthday, [Sales] = @Sales, [TelNo] = @TelNo, [Sex] = @Sex WHERE [EmployeeId] = @EmployeeId">
                <DeleteParameters>
                    <asp:Parameter Name="EmployeeId" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="EmployeeId" Type="Int32" />
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="DepartmentId" Type="Int32" />
                    <asp:Parameter Name="Birthday" Type="DateTime" />
                    <asp:Parameter Name="Sales" Type="Decimal" />
                    <asp:Parameter Name="TelNo" Type="String" />
                    <asp:Parameter Name="Sex" Type="Boolean" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="DepartmentId" Type="Int32" />
                    <asp:Parameter Name="Birthday" Type="DateTime" />
                    <asp:Parameter Name="Sales" Type="Decimal" />
                    <asp:Parameter Name="TelNo" Type="String" />
                    <asp:Parameter Name="Sex" Type="Boolean" />
                    <asp:Parameter Name="EmployeeId" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            
        </div>
    </form>
</body>
</html>
