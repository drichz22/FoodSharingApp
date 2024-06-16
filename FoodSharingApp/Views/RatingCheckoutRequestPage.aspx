<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="RatingCheckoutRequestPage.aspx.cs" Inherits="FoodSharingApp.Views.RatingCheckoutRequestPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>RATING CHECKOUT REQUEST PAGE</h1>
    <br />
    <h1>Let's Rate</h1>
    <h1 id="ReceiverUsername" runat="server">[Username]</h1>
    <h2>How was the interaction?</h2>
    <br />
    <div>
        <asp:Label ID="RatingLbl" runat="server" Text="Rating" Style="margin-right: 20px"></asp:Label>
        <asp:TextBox ID="RatingTB" runat="server" Style="margin-right: 80px"></asp:TextBox>
        <asp:Button ID="RatingBtn" runat="server" Text="Rate" OnClick="RatingBtn_Click" />
        <br />
        <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
    </div>
    <br />
    <h4>Request Name</h4>
    <h6 id="RequestNameLbl" runat="server">[Request Name]</h6>
    <h4>Request Description</h4>
    <h6 id="RequestDescriptionLbl" runat="server">[Request Description]</h6>
    <br />
    <asp:Button ID="CheckoutRequestBtn" runat="server" Text="Checkout" OnClick="CheckoutRequestBtn_Click" />
</asp:Content>
