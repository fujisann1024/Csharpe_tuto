<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="TimeForm.aspx.cs" 
    Inherits="SecondWebApplication.Controls.WebForm1" %>

<!--追加-->
<%@ Register Src="~/Controls/TestControl1.ascx" TagPrefix="uc1" TagName="TestControl1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  
        <div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server"/>
            <asp:Label ID="Label1" runat="server"
                       Text="スケジュールの内容と時間を指定してください"></asp:Label><br />

            スケジュール内容
            <asp:TextBox ID="ScheduleTextBox" runat="server"
                         Colums="40"
                         MaxLength="40"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                        ControlToValidate="ScheduleTextBox"
                                        Display="Dynamic"
                                        ErrorMessage="スケジュール内容を入力して下さい">
                *
            </asp:RequiredFieldValidator><br />


            <!--追加-->
            <uc1:testcontrol1 runat="server" id="TestControl1" /><br />

            <asp:Button ID="Button1" runat="server" Text="送信" OnClick="Button1_Click"/>
        </div>
        
    </form>
</body>
</html>
