<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="DonatorReceiverPostChatPage.aspx.cs" Inherits="FoodSharingApp.Views.DonatorReceiverChatPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>You Are Chatting With</h1>
    <h1 id="UsernameLblPost" runat="server">[Username]</h1>
    <h1>as Food Donator</h1>
    <br />
    <h1>Chat Feature Coming in 2026!</h1>
    <br />
    <asp:Button ID="CheckoutPostBtn" runat="server" Text="Checkout" OnClick="CheckoutPostBtn_Click" />
</asp:Content>
