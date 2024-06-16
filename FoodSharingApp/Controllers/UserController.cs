using FoodSharingApp.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FoodSharingApp.Controllers
{
    public class UserController
    {
        protected Boolean isUsernameUnique(String username)
        {
            List<String> usernameList = UserHandler.getAllUsernames();
            for (int i = 0; i < usernameList.Count; i++)
            {
                if (username.Equals(usernameList[i])) return false;
            }
            return true;
        }
        protected Boolean isAlphaNumericSpecial(String password)
        {
            Boolean isValidChar = Regex.IsMatch(password, "^[a-zA-Z0-9!@#$%^&*()_+=\\-\\[\\]{};:'\",.<>?/|`~]+$");
            Boolean hasLetter = Regex.IsMatch(password, "[a-zA-Z]");
            Boolean hasDigit = Regex.IsMatch(password, "[0-9]");
            Boolean hasSpecialChar = Regex.IsMatch(password, "[!@#$%^&*()_+=\\-\\[\\]{};:'\",.<>?/|`~]");
            return isValidChar && hasLetter && hasDigit && hasSpecialChar;
        }
        public String Register(String username, String email, String password,
            String confirmPassword, String phoneNumber, String city, String role)
        {
            String lbl;
            //Validasi Username
            if (username == null || username.Length == 0)
            {
                lbl = "Username cannot be empty!";
                return lbl;
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                lbl = "Username length must be between 5 and 15 characters!";
                return lbl;
            }
            else if (!isUsernameUnique(username))
            {
                lbl = "Username must be unique!";
                return lbl;
            }

            //Validasi Email
            if (email == null || email.Length == 0)
            {
                lbl = "Email cannot be empty!";
                return lbl;
            }
            else if (!email.EndsWith(".com"))
            {
                lbl = "Email must end with '.com'!";
                return lbl;
            }

            //Validasi Password
            if (password == null || password.Length == 0)
            {
                lbl = "Password cannot be empty!";
                return lbl;
            }
            else if (!isAlphaNumericSpecial(password))
            {
                lbl = "Password must be alphanumeric and has a special character!";
                return lbl;
            }
            else if (!password.Equals(confirmPassword))
            {
                lbl = "Password must be equal with Confirm Password!";
                return lbl;
            }

            //Validasi ConfirmPassword
            if (confirmPassword == null || confirmPassword.Length == 0)
            {
                lbl = "Confirm Password cannot be empty!";
                return lbl;
            }
            else if (!confirmPassword.Equals(password))
            {
                lbl = "Confirm Password must be equal with Password!";
                return lbl;
            }

            //Validasi Phone Number
            if (phoneNumber == null || phoneNumber.Length == 0)
            {
                lbl = "Phone Number cannot be empty!";
                return lbl;
            }

            //Validasi City
            if (city == null || city.Length == 0)
            {
                lbl = "City cannot be empty!";
                return lbl;
            }

            //Validasi Role
            if (role != "Food Donator" && role != "Food Receiver" && role != "Volunteer")
            {
                lbl = "Role must be chosen!";
                return lbl;
            }

            float rating = 0;
            UserHandler.InsertUser(username, email, password, phoneNumber, city, role, rating);
            lbl = "Registration Successful!";
            return lbl;
        }
        public String Login(String username, String password)
        {
            String lbl;
            if (UserHandler.getUserFromUsernamePassword(username, password) == null)
            {
                lbl = "User not found";
                return lbl;
            };
            lbl = "Login Successful!";
            return lbl;
        }

        public String Rate(String Username, String Email, String Password, String PhoneNumber,
            String City, String Role, float Rating)
        {
            String lbl;

            if (Rating < 0 || Rating > 5)
            {
                lbl = "Rating must be between 0 and 5!";
                return lbl;
            }

            UserHandler.UpdateUser(Username, Email, Password, PhoneNumber, City, Role, Rating);
            lbl = "User Rated Successfully!";
            return lbl;
        }
    }
}