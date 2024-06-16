using FoodSharingApp.Handlers;
using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodSharingApp.Views
{
    public partial class ViewPostPage : System.Web.UI.Page
    {
        List<Post> posts = new List<Post>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewPostView.Visible = false;

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
                    ViewPostView.Visible = true;

                    if (!IsPostBack)
                    {
                        posts = PostHandler.getAllPosts();
                        PostGV.DataSource = posts;
                        PostGV.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                }
            }
        }

        protected void PostGV_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var post = e.Row.DataItem as Post;

                if (post != null)
                {
                    byte[] imageData = post.PostImage;

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

        protected void PostGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = PostGV.SelectedRow;
            String Username = row.Cells[0].Text;
            String PostTitle = row.Cells[1].Text;
            User user = UserHandler.getUserFromUsername(Username);
            Post post = PostHandler.getPostFromPostTitle(PostTitle);
            if (post != null)
            {
                Response.Redirect("~/Views/DonatorReceiverPostChatPage.aspx?id=" + user.UserID.ToString() +
    "&postId=" + post.PostID.ToString());
            }
            else
            {
                Response.Redirect("~/Views/DonatorReceiverPostChatPage.aspx?id=" + user.UserID.ToString() +
    "&postId=" + "1");
            }
        }
    }
}