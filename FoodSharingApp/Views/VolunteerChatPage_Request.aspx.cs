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
    public partial class VolunteerChatPage : System.Web.UI.Page
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
                    int userChatID = Convert.ToInt32(Request.QueryString["id"]);
                    User chatUser = UserHandler.getUserFromUserID(userChatID);
                    UsernameLbl.InnerText = chatUser.Username;
                }
                else
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                }
            }
        }

        protected void SetDoneBtn_Click(object sender, EventArgs e)
        {
            int RequestIdx = Convert.ToInt32(Request.QueryString["requestIndex"]);
            int RequestID = Convert.ToInt32(Request.QueryString["requestId"]);
            DateTime RequestOrderDate = Convert.ToDateTime(Request.QueryString["requestOrderDate"]);
            String RequestOrderStatus = "Done";

            OrderHandler.UpdateRequestOrder(RequestIdx, RequestID, RequestOrderDate, RequestOrderStatus);
            Response.Redirect("~/Views/ViewOrderPage.aspx");
        }
    }
}