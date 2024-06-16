using FoodSharingApp.Controllers;
using FoodSharingApp.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodSharingApp.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            String role = "";
            String username = UsernameTB.Text;
            String email = EmailTB.Text;
            String password = PasswordTB.Text;
            String confirmPassword = ConfirmPasswordTB.Text;
            String phoneNumber = PhoneNumberTB.Text;
            String city = CityTB.Text;

            if (RadioButtonDonator.Checked)
            {
                role = "Food Donator";
            }
            else if (RadioButtonReceiver.Checked)
            {
                role = "Food Receiver";
            }
            else if (RadioButtonVolunteer.Checked)
            {
                role = "Volunteer";
            }

            ErrorLbl.Text = userController.Register(username, email, password, confirmPassword,
                phoneNumber, city, role);
            if (ErrorLbl.Text == "Registration Successful!")
            {
                Response.Redirect("~/Views/LoginPage.aspx");
            }
        }
    }
}