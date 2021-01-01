<%@ Control Language="C#" AutoEventWireup="true"
    CodeBehind="TestControl1.ascx.cs"
    Inherits="SecondWebApplication.WebUserControl1" %>
<!--ユーザー独自のコントロールを作成する-->
<asp:TextBox ID="HourTextBox" runat="server" 
             Colums="4"
             MaxLength="2"></asp:TextBox>時
<asp:TextBox ID="MinuteTextBox" runat="server"
             Colums="4"
             MaxLength="2">
</asp:TextBox>分

<!--「時」に関してのバリデーター-->
<asp:RangeValidator ID="RangeValidator1" runat="server"
                    ControlToValidate="HourTextBox"
                    ErrorMessage="時間は0-23の値の間で入力して下さい"
                    MaximumValue="23"
                    MinimumValue="0"
                    Type="Integer"
                    Text="*"
                    Display="Dynamic"></asp:RangeValidator>

<!--「分」に関してのバリデーター-->
<asp:RangeValidator ID="RangeValidator2" runat="server"
                    ControlToValidate="MinuteTextBox"
                    ErrorMessage="分は0-59の値で入力して下さい"
                    MaximumValue="59"
                    MinimumValue="0"
                    Type="Integer"
                    Text="*"
                    Display="Dynamic"></asp:RangeValidator>