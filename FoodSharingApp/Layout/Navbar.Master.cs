using FoodSharingApp.Handlers;
using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodSharingApp.Layout
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DonatorView.Visible = false;
            ReceiverView.Visible = false;
            VolunteerView.Visible = false;

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
                if (user.Role == "Food Donator")
                {
                    DonatorView.Visible = true;
                }
                if (user.Role == "Food Receiver")
                {
                    ReceiverView.Visible = true;
                }
                if (user.Role == "Volunteer")
                {
                    VolunteerView.Visible = true;
                }
            }
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            string[] cookie_keys = Request.Cookies.AllKeys;
            foreach (string key in cookie_keys)
            {
                HttpCookie cookie = new HttpCookie(key);
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }
            Session.Remove("user");
            Response.Redirect("~/Views/LoginPage.aspx");
        }      
    }
}