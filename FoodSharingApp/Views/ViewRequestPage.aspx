<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="ViewRequestPage.aspx.cs" Inherits="FoodSharingApp.Views.ViewRequestPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>VIEW REQUESTS</h1>
    <br />
    <div id="ViewRequestView" runat="server">
        <asp:GridView ID="RequestGV" runat="server" AutoGenerateColumns="False" OnRowDataBound="RequestGV_RowDataBound" OnSelectedIndexChanged="RequestGV_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="User.Username" HeaderText="Username" SortExpression="User.Username" />
                <asp:BoundField DataField="RequestTitle" HeaderText="Request Title" SortExpression="RequestTitle" />
                <asp:BoundField DataField="RequestDescription" HeaderText="Request Description" SortExpression="RequestDescription" />
                <asp:TemplateField HeaderText="Request Image">
                    <ItemTemplate>
                        <asp:Image ID="RequestImage" runat="server" Width="100px" Height="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="RequestLocation" HeaderText="Request Location" SortExpression="RequestLocation" />
                <asp:BoundField DataField="RequestDate" HeaderText="Request Date" SortExpression="RequestDate" DataFormatString="{0:MM/dd/yyyy}"/>
                <asp:BoundField DataField="FoodExpirationDate" HeaderText="Food Expiration Date" SortExpression="FoodExpirationDate" DataFormatString="{0:MM/dd/yyyy}"/>
                <asp:BoundField DataField="AllergenInformation" HeaderText="Allergen Information" SortExpression="AllergenInformation" />
                <asp:CommandField ButtonType="Button" HeaderText="Chat" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
