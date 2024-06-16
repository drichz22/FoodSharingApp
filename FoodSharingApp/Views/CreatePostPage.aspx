<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Navbar.Master" AutoEventWireup="true" CodeBehind="CreatePostPage.aspx.cs" Inherits="FoodSharingApp.Views.CreatePostPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="CreatePostView" runat="server">
        <h1>CREATE POST</h1>
        <br />
        <div>
            <asp:Label ID="PostTitleLbl" runat="server" Text="Post Title" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="PostTitleTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PostDescriptionLbl" runat="server" Text="Post Description" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="PostDescriptionTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PostLocationLbl" runat="server" Text="Post Location" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="PostLocationTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="FoodExpirationDateLbl" runat="server" Text="Food Expiration Date (ex. 06/11/2024)" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="FoodExpirationTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="DietaryInfoLbl" runat="server" Text="Dietary Information (ex. Gluten Free, Sugar Free)" Style="margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="DietaryInfoTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PostImageLbl" runat="server" Text="Post Image" Style="margin-right: 10px;"></asp:Label>
            <asp:FileUpload ID="PostImageUpload" runat="server" />
        </div>
        <br />
        <div>
            <asp:Button ID="MakePostBtn" runat="server" Text="Make Post" OnClick="MakePostBtn_Click" />
        </div>
        <br />
        <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
    </div>
</asp:Content>
