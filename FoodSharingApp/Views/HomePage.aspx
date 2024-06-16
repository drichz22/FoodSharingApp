<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FoodSharingApp.Views.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="HomeView" runat="server">
        <h1>HOME PAGE</h1>
        <br />
        <h1 style="font-weight: 400">Hello,</h1>
        <h1 id="WelcomeLabel" runat="server">[Username]</h1>
        <br />
        <h3>Rating</h3>
        <h3 id="UserRating" runat="server">[Rating]</h3>
        <asp:Image ID="imgProfile" runat="server" ImageUrl="~/Images/HomeImage.png" AlternateText="FoodSharingLogo" CssClass=".img500x500" />
    </div>
</asp:Content>
