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
    public partial class RateDriver : System.Web.UI.Page
    {
        List<User> users = new List<User>();
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
                if (!IsPostBack)
                {
                    users = UserHandler.getAllUsersWithCondition("Volunteer");
                    DriverGV.DataSource = users;
                    DriverGV.DataBind();
                }
            }
        }

        protected void RateBtn_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();

            Button btn = (Button)sender;
            int index = Convert.ToInt32(btn.CommandArgument);
            GridViewRow row = DriverGV.Rows[index];
            String DriverName = row.Cells[0].Text;
            User driver = UserHandler.getUserFromUsername(DriverName);
            String Email = driver.Email;
            String Password = driver.Password;
            String PhoneNumber = driver.PhoneNumber;
            String Role = driver.Role;
            String DriverCity = row.Cells[1].Text;
            TextBox rateTextBox = (TextBox)row.FindControl("RateTB");
            float Rating = float.Parse(rateTextBox.Text);
            Label ErrorLbl = (Label)row.FindControl("RateLblError");

            ErrorLbl.Text = userController.Rate(DriverName, Email, Password, PhoneNumber, DriverCity,
                Role, Rating);
            if (ErrorLbl.Text == "User Rated Successfully!")
            {
                users = UserHandler.getAllUsersWithCondition("Volunteer");
                DriverGV.DataSource = users;
                DriverGV.DataBind();
            }
        }
    }
}