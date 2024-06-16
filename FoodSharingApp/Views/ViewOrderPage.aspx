<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="ViewOrderPage.aspx.cs" Inherits="FoodSharingApp.Views.ViewOrderPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>VIEW ORDER</h1>
    <br />
    <div id="ViewOrderView" runat="server">
        <h1>FOOD POST</h1>
        <asp:GridView ID="PostOrderGV" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="PostOrderGV_SelectedIndexChanged" OnRowDataBound="PostOrderGV_RowDataBound">
            <Columns>
                <asp:BoundField DataField="Post.PostTitle" HeaderText="Post Title" SortExpression="Post.PostTitle" />
                <asp:BoundField DataField="Post.PostDescription" HeaderText="Post Description" SortExpression="Post.PostDescription" />
                <asp:TemplateField HeaderText="Post Image">
                    <ItemTemplate>
                        <asp:Image ID="PostImage" runat="server" Width="100px" Height="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Post.PostLocation" HeaderText="Post Location" SortExpression="Post.PostLocation" />
                <asp:BoundField DataField="PostOrderDate" HeaderText="Order Date" SortExpression="PostOrderDate" />
                <asp:BoundField DataField="PostOrderStatus" HeaderText="Order Status" SortExpression="PostOrderStatus" />
                <asp:CommandField ButtonType="Button" HeaderText="Chat" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <h1>FOOD REQUEST</h1>
        <asp:GridView ID="RequestOrderGV" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="PostRequestGV_SelectedIndexChanged" OnRowDataBound="PostRequestGV_RowDataBound">
            <Columns>
                <asp:BoundField DataField="Request.RequestTitle" HeaderText="Request Name" SortExpression="Request.RequestTitle" />
                <asp:BoundField DataField="Request.RequestDescription" HeaderText="Request Description" SortExpression="Request.RequestDescription" />
                <asp:TemplateField HeaderText="Request Image">
                    <ItemTemplate>
                        <asp:Image ID="RequestImage" runat="server" Width="100px" Height="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Request.RequestLocation" HeaderText="Request Location" SortExpression="Request.RequestLocation" />
                <asp:BoundField DataField="RequestOrderDate" HeaderText="Order Date" SortExpression="RequestOrderDate" />
                <asp:BoundField DataField="RequestOrderStatus" HeaderText="Order Status" SortExpression="RequestOrderStatus" />
                <asp:CommandField ButtonType="Button" HeaderText="Chat" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
