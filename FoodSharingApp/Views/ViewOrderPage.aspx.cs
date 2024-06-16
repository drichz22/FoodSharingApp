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
    public partial class ViewOrderPage : System.Web.UI.Page
    {
        List<PostOrder> postOrders = new List<PostOrder>();
        List<RequestOrder> requestOrders = new List<RequestOrder>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewOrderView.Visible = false;

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
                if (user.Role.Equals("Volunteer"))
                {
                    ViewOrderView.Visible = true;

                    if (!IsPostBack)
                    {
                        postOrders = OrderHandler.getAllPostOrders();
                        PostOrderGV.DataSource = postOrders;
                        PostOrderGV.DataBind();

                        requestOrders = OrderHandler.getAllRequestOrders();
                        RequestOrderGV.DataSource = requestOrders;  
                        RequestOrderGV.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                }
            }
        }

        protected void PostRequestGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = RequestOrderGV.SelectedRow;
            int RequestIndex = RequestOrderGV.SelectedIndex + 1;
            String RequestTitle = row.Cells[0].Text;
            String requestOrderDate = row.Cells[4].Text;
            Request request = PostHandler.getRequestFromRequestTitle(RequestTitle);

            if (request != null)
            {
                Response.Redirect("~/Views/VolunteerChatPage_Request.aspx?id=" + request.UserID.ToString() +
    "&requestId=" + request.RequestID.ToString() + "&requestOrderDate=" + requestOrderDate
    + "&requestIndex=" + RequestIndex.ToString());
            }
            else
            {
                Response.Redirect("~/Views/VolunteerChatPage_Request.aspx?id=" + "1" +
    "&requestId=" + "1" + "&requestOrderDate=" + requestOrderDate 
    + "&requestIndex=" + RequestIndex.ToString());
            }
        }

        protected void PostOrderGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = PostOrderGV.SelectedRow;
            int PostIndex = PostOrderGV.SelectedIndex + 1;
            String PostTitle = row.Cells[0].Text;
            Post post = PostHandler.getPostFromPostTitle(PostTitle);
            String postOrderDate = row.Cells[4].Text;

            if (post != null)
            {
                Response.Redirect("~/Views/VolunteerPostChatPage.aspx?id=" + post.UserID.ToString() +
    "&postId=" + post.PostID.ToString() + "&postOrderDate=" + postOrderDate
    + "&postIndex=" + PostIndex.ToString());
            }
            else
            {
                Response.Redirect("~/Views/VolunteerPostChatPage.aspx?id=" + "1" +
    "&postId=" + "1" + "&postOrderDate=" + postOrderDate
    + "&postIndex=" + PostIndex.ToString());
            }
        }

        protected void PostOrderGV_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var post = e.Row.DataItem as PostOrder;

                if (post != null)
                {
                    Post getPost = PostHandler.getPostFromPostID(post.PostID);
                    byte[] imageData = getPost.PostImage;

                    if (imageData != null && imageData.Length > 0)
                    {
                        string base64String = Convert.ToBase64String(imageData);
                        Image imgPost = (Image)e.Row.FindControl("PostImage");

                        if (imgPost != null)
                        {
                            imgPost.ImageUrl = $"data:image/jpeg;base64,{base64String}";
                        }
                    }
                    else
                    {
                        Image imgPost = (Image)e.Row.FindControl("PostImage");
                        if (imgPost != null)
                        {
                            imgPost.ImageUrl = "~/Images/Arbys_MeatMountain_hero_17_b.0.jpg";
                        }
                    }
                }
            }
        }

        protected void PostRequestGV_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var request = e.Row.DataItem as RequestOrder;

                if (request != null)
                {
                    Request getRequest = PostHandler.getRequestFromRequestID(request.RequestID);
                    byte[] imageData = getRequest.RequestImage;

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
    }
}