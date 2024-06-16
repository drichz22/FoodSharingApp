using FoodSharingApp.Controllers;
using FoodSharingApp.Handlers;
using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodSharingApp.Views
{
    public partial class CreatePostPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreatePostView.Visible = false;

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/LoginPage.aspx");
            }
            else
            {
                User user = new User();
                if (Session["user"] == null)
                {
                    int userID = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                    user = UserHandler.getUserFromUserID(userID);
                    Session["user"] = user;
                }
                else
                {
                    user = (User)Session["user"];
                }
                if (user.Role.Equals("Food Donator"))
                {
                    CreatePostView.Visible = true;                   
                }
                else
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                }
            }
        }

        protected void MakePostBtn_Click(object sender, EventArgs e)
        {
            PostController postController = new PostController();

            User user = (User)Session["user"];
            int UserID = user.UserID;
            String PostTitle = PostTitleTB.Text;
            String PostDescription = PostDescriptionTB.Text;
            String PostLocation = PostLocationTB.Text;
            DateTime FoodExpirationDate = Convert.ToDateTime(FoodExpirationTB.Text);
            String DietaryInfo = DietaryInfoTB.Text;
            Byte[] fileData = PostImageUpload.FileBytes;

            ErrorLbl.Text = postController.MakePost(UserID, PostTitle, PostDescription, fileData,
                PostLocation, FoodExpirationDate, DietaryInfo);
            if (ErrorLbl.Text == "Post Created Successfully!")
            {
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }
    }
}