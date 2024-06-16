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
    public partial class DonatorReceiverChatPage_Request : System.Web.UI.Page
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
                if (Request.QueryString["id"] != null)
                {
                    int userChatID = Convert.ToInt32(Request.QueryString["Id"]);
                    User chatUser = UserHandler.getUserFromUserID(userChatID);
                    UsernameLblRequest.InnerText = chatUser.Username;
                }
                else
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                }
            }
        }
        
        protected void CheckoutRequestBtn_Click(object sender, EventArgs e)
        {
            String userChatID = Request.QueryString["id"];
            String RequestID = Request.QueryString["requestId"];
            Response.Redirect("~/Views/RatingCheckoutRequestPage.aspx?userRequestId=" + userChatID
            + "&foodRequestId=" + RequestID);
        }
    }
}