<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckForm.aspx.cs" Inherits="SecondWebApplication.Form.CheckForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <!--
        検証コントロールの種類と機能
            RequiredFieldValidator～入力必須項目を検証する
            RangeValidator～入力範囲を検証する
            CompareValidator～入力内容を比較して検証する
            RegularExpressionValidator～入力内容を正規表現で検証する
            CustomValidator～独自の方法で検証する
            ValidationSummary～検証結果のエラーメッセージをまとめて表示する
            -->

        <!--
          検証コントロールの主な共通プロパティ
            ControlToValidate       ～検証対象となるコントロールを指定する
            Display                ～エラーメッセージを検証コントロールで表示するか
            EnableClientScript     ～WebブラウザーでのJavaScriptによる検証を行うかどうか
            Enabled                ～検証コントロールの有効、無効を設定する
            ErrorMessage           ～検証エラー時に検証コントロールで表示するメッセージを指定する
            Text                   ～検証エラー時に検証コントロールで表示するメッセージを指定する
            IsValid                ～検証が成功したかどうかを取得。設定する
            SetFocusOnError        ～検証失敗時に検証対象コントロールにフォーカスを移動するかどうか
            ValidationGroup        ～この検証コントロールの属する検証グループを指定する
            -->
        <div>
            <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <!--Javascriptによる検証機能を持つためエラーが起きた時はポストバックは行われない-->
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ErrorMessage="テキストを入力して下さい"
                ControlToValidate="TextBox1">
            </asp:RequiredFieldValidator><br />

            <asp:Button ID="Button1" runat="server" Text="送信" OnClick="Button1_Click"/>
        </div>

        <div>
            <asp:Label ID="ResultLabel2" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"
                Text="テキストを入力して下さい" Columns="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                runat="server" ErrorMessage="初期値から値を変更してください" ControlToValidate="TextBox2"
                InitialValue="テキストを入力して下さい">
            </asp:RequiredFieldValidator><br />

            <asp:Button ID="Button2" runat="server" Text="送信"/>
        </div>

        <!--  
         入力範囲を検証する
            MinimumValue～入力範囲の最小値
            MaximumValue～入力範囲の最大値
            Type～入力値のデータ型
            -->
        <div>
            年齢<asp:TextBox ID="Age" runat="server" Text=""></asp:TextBox><br />
            <asp:RangeValidator ID="RangeValidator1" runat="server"
                ControlToValidate="Age" ErrorMessage="年齢は0－150歳以上の範囲で入力して下さい"
                MaximumValue="150" Type="Integer" MinimumValue="0"></asp:RangeValidator>
            <br />
            生年月日<asp:TextBox ID="BirthDay" runat="server" Text=""></asp:TextBox><br />
            <asp:RangeValidator ID="RangeValidator2" runat="server"
                ControlToValidate="Birthday" Type="Date"
                ErrorMessage="誕生日は1985年以降を指定してください"
                MinimumValue="1850/1/1" MaximumValue="9999/1/1"></asp:RangeValidator>

            <asp:Button ID="Button3" runat="server" Text="送信"/>
        </div><br />
        <!--
            入力内容を比較して検証する
            CompareValidatorコントロール
                Operator            ～比較方法を指定する
                    Operatorに入れる値
                       Equal            ～値が等しい
                       NotEqual         ～値が等しくない
                       GreaterThan      ～値が大きい
                       GreaterThanEqual ～値が等しいか大きい
                       LessThan         ～値が小さい
                       LessThanEqual    ～値が等しいか小さい
                       DateTypeCheck
                ControlToCompare    ～比較対象のコントロールを指定する
                ValueToCompare      ～比較対象の低数値を指定する
                Type                ～入力の型
            -->
        <div>
             生年<asp:TextBox ID="Birth" runat="server" Text=""></asp:TextBox>

             小学校入学年<asp:TextBox ID="Enroll" runat="server" Text=""></asp:TextBox>

            <asp:CompareValidator ID="CompareValidator1" runat="server"
                                  ErrorMessage="生年は小学校入学年よりも前である必要がある"
                                  ControlToCompare="Enroll" 
                                  ControlToValidate="Birth"
                                  Operator="LessThan" 
                                  Type="Integer" ></asp:CompareValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server"
                                  ErrorMessage="生年は1850年よりも後である必要がある"
                                  ControlToValidate="Birth" 
                                  Operator="GreaterThan"
                                  ValueToCompare="1850" 
                                  Type="Integer"></asp:CompareValidator>

            <asp:Button ID="Button4" runat="server" Text="送信"/>
        </div><br />


        <!--正規表現で検証する
            RegularExpressionValidation-->
        <div>
            郵便番号<asp:TextBox ID="TextBox3" runat="server" Text="" Columns="50"></asp:TextBox><br />

            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                            ErrorMessage="郵便番号を正しく入力して下さい"
                                            ControlToValidate="TextBox3"
                                            ValidationExpression="\d{3}(-(\d{4}|\d{2}))?">

            </asp:RegularExpressionValidator><br />

            <asp:Button ID="Button5" runat="server" Text="送信"/>
        </div>

        <div>
            <!--検証方法をカスタマイズする
                CustomValidatorコントロール
                    ServerValidatorイベント           ～サーバーサイドの検証イベント
                    CilentValidationFunctionプロパティ～クライアントサイドの検証を行う関数名を指定
              -->
            入力<asp:TextBox ID="TextBox4" runat="server" Text=""></asp:TextBox>

            <asp:CustomValidator ID="CustomValidator1" runat="server"
                ErrorMessage="入力内容にASP.NETという文字列が含まれていません"
                OnServerValidate="CustomValidator1_ServerValidator"
                ClientValidationFunction ="clientValidate"
                ControlToValidate="TextBox4"></asp:CustomValidator>

            <asp:Button ID="Button6" runat="server" Text="送信" />
        </div>

        <!--
            検証エラーを表示する
            ValidationSummary
                ShowMessageBoxプロパティ～エラーメッセージをJavaScriptのalert関数を使ってダイアログ表示する
                ShowSummary             ～エラーメッセージをWebページ上に表示する
                DisplayMode             ～表示方式を指定する
                    List　　　　     ～エラーメッセージごとに改行して表示
                    BulletList       ～ulタグ(箇条書きリスト)で表示。デフォルト値
                    SingleParagraph  ～改行せず続けて表示

                HeaderText              ～エラーメッセージの上に表示するテキストを指定する
            -->
    </form>
    <script type="text/javascript">
        //クライアントサイドで検証を行う関数
        function clientValidate(src, args) {
            //サーバーサイドと同じく、ASP.NETという文字列が含まれているかどうかで検証
            if (args.Value.indexOf("ASP.NET") >= 0) {
                args.IsValid = true;
            } else {
                args.IsValid = false;
            }
        }
    </script>
</body>
</html>
