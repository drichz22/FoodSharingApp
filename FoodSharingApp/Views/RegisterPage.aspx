<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="FoodSharingApp.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;800&display=swap" rel="stylesheet" />
    <link href="../Styles/PageStyling.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>REGISTER PAGE</h1>
        <hr />
        <div>
            <asp:Label ID="UsenameLbl" runat="server" Text="Username" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="UsernameTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="EmailLbl" runat="server" Text="Email" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="EmailTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PasswordLbl" runat="server" Text="Password" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="PasswordTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="ConfirmPasswordLbl" runat="server" Text="Confirm Password" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="ConfirmPasswordTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PhoneNumberLbl" runat="server" Text="Phone Number" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="PhoneNumberTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="CityLbl" runat="server" Text="City" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="CityTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="RoleLbl" runat="server" Text="Role" Style="margin-right: 10px;"></asp:Label>
            <asp:RadioButton ID="RadioButtonDonator" runat="server" Text="Food Donator" GroupName="RoleGroup" Style="margin-right: 10px;" />
            <asp:RadioButton ID="RadioButtonReceiver" runat="server" Text="Food Receiver" GroupName="RoleGroup" Style="margin-right: 10px;" />
            <asp:RadioButton ID="RadioButtonVolunteer" runat="server" Text="Volunteer" GroupName="RoleGroup" />
        </div>
        <br />
        <div>
            <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click" />
        </div>
        <div>
            <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
        </div>
        <br />
        <div>
            <a href="LoginPage.aspx">Already Have an Account?</a>
        </div>
    </form>
</body>
</html>
