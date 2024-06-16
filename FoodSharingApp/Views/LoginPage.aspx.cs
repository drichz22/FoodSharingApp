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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            String Username = UsernameTB.Text;
            String Password = PasswordTB.Text;
            Boolean RememberMe = RememberMeCheckbox.Checked;

            ErrorLbl.Text = userController.Login(Username, Password);
            if (ErrorLbl.Text == "Login Successful!")
            {
                User user = UserHandler.getUserFromUsernamePassword(Username, Password);
                Session["user"] = user;
                if (RememberMe)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.UserID.ToString();
                    cookie.Expires = DateTime.Now.AddDays(1);
                    cookie.Path = "/";
                    cookie.Secure = true;
                    cookie.HttpOnly = true;
                    Response.Cookies.Add(cookie);
                }
                if (Application["user_count"] == null)
                {
                    Application["user_count"] = 1;
                }
                else
                {
                    Application["user_count"] = ((int)Application["user_count"]) + 1;
                }
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }
    }
}