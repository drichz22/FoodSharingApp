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
    public partial class CreateRequestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateRequestView.Visible = false;

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
                if (user.Role.Equals("Food Receiver"))
                {
                    CreateRequestView.Visible = true;
                }
                else
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                }
            }
        }

        protected void MakeRequestBtn_Click(object sender, EventArgs e)
        {
            RequestController requestController = new RequestController();

            User user = (User)Session["user"];
            int UserID = user.UserID;
            String RequestTitle = RequestTitleTB.Text;
            String RequestDescription = RequestDescriptionTB.Text;
            String RequestLocation = RequestLocationTB.Text;
            DateTime FoodExpirationDate = Convert.ToDateTime(FoodExpirationTB.Text);
            String AllergenInfo = AllergenInfoTB.Text;
            Byte[] fileData = RequestImageUpload.FileBytes;

            ErrorLbl.Text = requestController.MakeRequest(UserID, RequestTitle, RequestDescription,
                fileData, RequestLocation, FoodExpirationDate, AllergenInfo);
            if (ErrorLbl.Text == "Request Created Successfully!")
            {
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }
    }
}