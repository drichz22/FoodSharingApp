<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="RateDriver.aspx.cs" Inherits="FoodSharingApp.Views.RateDriver" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Need Notification Features for Food Donator and Receiver</h1>
    <h1>Coming in 2026!</h1>
    <br />
    <h1>Mockup Rate Driver</h1>
    <asp:GridView ID="DriverGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Username" HeaderText="Driver Name" SortExpression="Username" />
            <asp:BoundField DataField="City" HeaderText="Driver City" SortExpression="City" />
            <asp:BoundField DataField="Rating" HeaderText="Driver Rating" SortExpression="Rating" DataFormatString="{0:F2}"/>
            <asp:TemplateField HeaderText="Rate">
                <ItemTemplate>
                    <asp:TextBox ID="RateTB" runat="server" Text=" "></asp:TextBox>
                    <asp:Button ID="RateBtn" runat="server" Text="Rate" OnClick="RateBtn_Click" CommandArgument="<%# Container.DataItemIndex %>" />
                    <asp:Label ID="RateLblError" runat="server" Text=" " ForeColor="Red"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
