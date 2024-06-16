using FoodSharingApp.Controllers;
using FoodSharingApp.Handlers;
using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodSharingApp.Views
{
    public partial class RatingCheckoutPostPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
                if (Request.QueryString["userPostId"] != null && Request.QueryString["foodPostId"] != null)
                {
                    int userRateID = Convert.ToInt32(Request.QueryString["userPostId"]);
                    User rateUser = UserHandler.getUserFromUserID(userRateID);
                    DonatorUsername.InnerText = rateUser.Username;
                    int PostID = Convert.ToInt32(Request.QueryString["foodPostId"]);
                    Post post = PostHandler.getPostFromPostID(PostID);
                    PostNameLbl.InnerText = post.PostTitle;
                    PostDescriptionLbl.InnerText = post.PostDescription;
                }
                else
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                }
            }
        }

        protected void RatingBtn_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();

            int userRateID = Convert.ToInt32(Request.QueryString["userPostId"]);
            User rateUser = UserHandler.getUserFromUserID(userRateID);
            String Username = rateUser.Username;
            String Email = rateUser.Email;
            String Password = rateUser.Password;
            String PhoneNumber = rateUser.PhoneNumber;
            String City = rateUser.City;
            String Role = rateUser.Role;
            float Rating = float.Parse(RatingTB.Text);

            ErrorLbl.Text = userController.Rate(Username, Email, Password, PhoneNumber, City,
                Role, Rating);
            if (ErrorLbl.Text == "User Rated Successfully!")
            {
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void CheckoutPostBtn_Click(object sender, EventArgs e)
        {
            int PostID = Convert.ToInt32(Request.QueryString["foodPostId"]);
            DateTime PostOrderDate = DateTime.Now;
            String PostOrderStatus = "Ongoing";

            OrderHandler.InsertPostOrder(PostID, PostOrderDate, PostOrderStatus);
            Response.Redirect("~/Views/HomePage.aspx");
        }
    }
}