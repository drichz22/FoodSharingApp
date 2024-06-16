<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="DonatorReceiverChatPage_Request.aspx.cs" Inherits="FoodSharingApp.Views.DonatorReceiverChatPage_Request" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>You Are Chatting With</h1>
    <h1 id="UsernameLblRequest" runat="server">[Username]</h1>
    <h1>as Food Receiver</h1>
    <br />
    <h1>Chat Feature Coming in 2026!</h1>
    <br />
    <asp:Button ID="CheckoutRequestBtn" runat="server" Text="Checkout" OnClick="CheckoutRequestBtn_Click" />
</asp:Content>
