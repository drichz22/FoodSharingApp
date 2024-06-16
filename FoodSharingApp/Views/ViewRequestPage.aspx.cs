using FoodSharingApp.Handlers;
using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodSharingApp.Views
{
    public partial class ViewRequestPage : System.Web.UI.Page
    {
        List<Request> requests = new List<Request>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewRequestView.Visible = false;

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
                    ViewRequestView.Visible = true;

                    if (!IsPostBack)
                    {
                        requests = PostHandler.getAllRequests();
                        RequestGV.DataSource = requests;
                        RequestGV.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                }
            }
        }

        protected void RequestGV_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var request = e.Row.DataItem as Request;

                if (request != null)
                {
                    byte[] imageData = request.RequestImage;

                    if (imageData != null && imageData.Length > 0)
                    {
                        string base64String = Convert.ToBase64String(imageData);
                        Image imgPost = (Image)e.Row.FindControl("RequestImage");

                        if (imgPost != null)
                        {
                            imgPost.ImageUrl = $"data:image/jpeg;base64,{base64String}";
                        }
                    }
                    else
                    {
                        Image imgPost = (Image)e.Row.FindControl("RequestImage");
                        if (imgPost != null)
                        {
                            imgPost.ImageUrl = "~/Images/krabbypatty.jpg";
                        }
                    }
                }
            }
        }

        protected void RequestGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = RequestGV.SelectedRow;
            String Username = row.Cells[0].Text;
            String RequestTitle = row.Cells[1].Text;
            User user = UserHandler.getUserFromUsername(Username);
            Request request = PostHandler.getRequestFromRequestTitle(RequestTitle);
            if (request != null)
            {
                Response.Redirect("~/Views/DonatorReceiverChatPage_Request.aspx?id=" + user.UserID.ToString() +
    "&requestId=" + request.RequestID.ToString());
            }
            else
            {
                Response.Redirect("~/Views/DonatorReceiverChatPage_Request.aspx?id=" + user.UserID.ToString() +
    "&requestId=" + "1");
            }
        }
    }
}