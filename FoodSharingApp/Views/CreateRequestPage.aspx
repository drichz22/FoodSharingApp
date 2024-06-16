<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="CreateRequestPage.aspx.cs" Inherits="FoodSharingApp.Views.CreateRequestPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="CreateRequestView" runat="server">
        <h1>CREATE REQUEST</h1>
        <br />
        <div>
            <asp:Label ID="RequestTitleLbl" runat="server" Text="Request Title" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="RequestTitleTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="RequestDescriptionLbl" runat="server" Text="Request Description" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="RequestDescriptionTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="RequestLocationLbl" runat="server" Text="Request Location" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="RequestLocationTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="FoodExpirationDateLbl" runat="server" Text="Food Expiration Date (ex. 06/11/2024)" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="FoodExpirationTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="AllergenInfoLbl" runat="server" Text="Allergen Information (ex. No Dairy, No Gluten)" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="AllergenInfoTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="RequestImageLbl" runat="server" Text="Request Image" Style="margin-right: 10px;"></asp:Label>
            <asp:FileUpload ID="RequestImageUpload" runat="server" />
        </div>
        <br />
        <div>
            <asp:Button ID="MakeRequestBtn" runat="server" Text="Make Request" OnClick="MakeRequestBtn_Click"/>
        </div>
        <br />
        <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
    </div>
</asp:Content>
