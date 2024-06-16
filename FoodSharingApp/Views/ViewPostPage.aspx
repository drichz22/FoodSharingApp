<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="ViewPostPage.aspx.cs" Inherits="FoodSharingApp.Views.ViewPostPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>VIEW POSTS</h1>
    <br />
    <div id="ViewPostView" runat="server">
        <asp:GridView ID="PostGV" runat="server" AutoGenerateColumns="False" OnRowDataBound="PostGV_RowDataBound" OnSelectedIndexChanged="PostGV_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="User.Username" HeaderText="Username" SortExpression="User.Username" />
                <asp:BoundField DataField="PostTitle" HeaderText="Post Title" SortExpression="PostTitle" />
                <asp:BoundField DataField="PostDescription" HeaderText="Post Description" SortExpression="PostDescription" />              
                <asp:TemplateField HeaderText="Post Image">
                    <ItemTemplate>
                        <asp:Image ID="PostImage" runat="server" Width="100px" Height="100px" />
                    </ItemTemplate>
                </asp:TemplateField>                
                <asp:BoundField DataField="PostLocation" HeaderText="Post Location" SortExpression="PostLocation"/>
                <asp:BoundField DataField="PostDate" HeaderText="Post Date" SortExpression="PostDate" DataFormatString="{0:MM/dd/yyyy}"/>
                <asp:BoundField DataField="FoodExpirationDate" HeaderText="Food Expiration Date" SortExpression="FoodExpirationDate" DataFormatString="{0:MM/dd/yyyy}"/>
                <asp:BoundField DataField="DietaryInformation" HeaderText="Dietary Information" SortExpression="DietaryInformation" />                
                <asp:CommandField ButtonType="Button" HeaderText="Chat" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
