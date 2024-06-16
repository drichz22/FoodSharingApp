<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="RatingCheckoutPostPage.aspx.cs" Inherits="FoodSharingApp.Views.RatingCheckoutPostPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>RATING CHECKOUT POST PAGE</h1>
    <br />
    <h1>Let's Rate</h1>
    <h1 id="DonatorUsername" runat="server">[Username]</h1>
    <h2>How was the interaction?</h2>
    <br />
    <div>
        <asp:Label ID="RatingLbl" runat="server" Text="Rating" Style="margin-right: 20px"></asp:Label>
        <asp:TextBox ID="RatingTB" runat="server" Style="margin-right: 80px"></asp:TextBox>
        <asp:Button ID="RatingBtn" runat="server" Text="Rate" OnClick="RatingBtn_Click"/>
        <br />
        <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
    </div>
    <br />
    <h4>Post Name</h4>
    <h6 id="PostNameLbl" runat="server">[Post Name]</h6>
    <h4>Post Description</h4>
    <h6 id="PostDescriptionLbl" runat="server">[Post Description]</h6>
    <br />
    <asp:Button ID="CheckoutPostBtn" runat="server" Text="Checkout" OnClick="CheckoutPostBtn_Click"/>
</asp:Content>
