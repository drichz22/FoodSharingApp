using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Factories
{
    public class UserFactory
    {
        public static User Create(String Username, String Email, String Password, String PhoneNumber, String City,
            String Role, float Rating)
        {
            User user = new User();
            user.Username = Username;
            user.Email = Email;
            user.Password = Password;
            user.PhoneNumber = PhoneNumber;
            user.City = City;
            user.Role = Role;
            user.Rating = Rating;
            return user;
        }
    }
}