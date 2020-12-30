<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TestForm2.aspx.vb" Inherits="TestApplication.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
      <!--入力用コントロールの使用-->
    <!--
        TextMode～入力モードの切り替え
        Columns～表示幅の指定
        MaxLength～入力可能な最大文字数の指定
        ReadOnly～内容を変更可能か
        Text～テキストボックスのテキスト
        Rows～行数の指定
        Wrap～テキストを右端で表示するかどうかの指定
        -->
    <!--フォームタグの中に入れないとエラーになる
        idはページによって変える-->
    <form id="form2" runat="server">
        <asp:Label ID="Label1" runat="server" Text="text内容"></asp:Label><br />
        <!--inputタグ (type=text)-->
        <asp:TextBox ID="TextBox1" runat="server" Columns="30" MaxLength="30" Text="テキストを入力して下さい"
            ></asp:TextBox>SingleLine<br />

        <asp:Label ID="Label2" runat="server" Text="textarea内容"></asp:Label><br />
        <!--textareaタグ-->
        <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Rows="8"
            AutoPostBack="true" OnTextChanged="Button2_Click"></asp:TextBox>MultiLine<br />

        <!--inputタグ (type=password)-->
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Columns="8" MaxLength="8"></asp:TextBox>Password<br />
        <!--ポストバック用のButtonコントロール
            buttonをクリックしたときに初めてTextChangedイベントが発生する
            自動ポストバック～TextChangedイベントが発生するタイミング
            
            -->
        <asp:Button ID="Button2" runat="server" Text="Button" /><br />


    <!--チェックボックス、ラジオボタンを使用する
        Checked～チェックされているかどうか
        GroupName～ラジオボタンのグループ名
        -->
        <asp:Label ID="Label3" runat="server" Text="check内容"></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="登録後、メールマガジンを受け取る"/>
        <br />
        どこでこのサイトを知りましたか<br />

        <asp:Label ID="Label4" runat="server" Text="radio内容"></asp:Label><br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="media" Text="テレビ"/>
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="media" Text="新聞"/>
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="media" Text="Web"/><br />

        <asp:Button ID="Button3" runat="server" Text="登録"/>
        
    </form>
</body>
</html>
