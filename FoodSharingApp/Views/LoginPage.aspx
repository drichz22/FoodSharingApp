<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FoodSharingApp.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;800&display=swap" rel="stylesheet" />
    <link href="../Styles/PageStyling.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>LOGIN PAGE</h1>
        <hr />
        <div>
            <asp:Label ID="UsenameLbl" runat="server" Text="Username" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="UsernameTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PasswordLbl" runat="server" Text="Password" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="PasswordTB" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:CheckBox ID="RememberMeCheckbox" runat="server" Text="Remember Me" />
        </div>
        <br />
        <div>
            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
        </div>
        <div>
            <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
        </div>
        <br />
        <div>
            <a href="LoginPage.aspx" style="margin-right: 40px">Forgot Password?</a>
            <a href="RegisterPage.aspx">Haven't Registered Yet?</a>
        </div>
    </form>
</body>
</html>
