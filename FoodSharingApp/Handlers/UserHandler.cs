using FoodSharingApp.Factories;
using FoodSharingApp.Models;
using FoodSharingApp.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Handlers
{
    public class UserHandler
    {
        public static List<String> getAllUsernames()
        {
            return UserRepository.getAllUsernames();
        }
        public static List<User> getAllUsersWithCondition(String Role)
        {
            return UserRepository.getAllUsersWithCondition(Role);
        }
        public static User getUserFromUsernamePassword(String Username, String Password)
        {
            return UserRepository.getUserFromUsernamePassword(Username, Password);
        }
        public static void InsertUser(String Username, String Email, String Password, String PhoneNumber,
            String City, String Role, float Rating)
        {
            UserRepository.InsertUser(Username, Email, Password, PhoneNumber, City, Role, Rating);
        }
        public static User getUserFromUserID(int UserID)
        {
            return UserRepository.getUserFromUserID(UserID);
        }
        public static User getUserFromUsername(String Username)
        {
            return UserRepository.getUserFromUsername(Username);
        }
        public static void UpdateUser(String Username, String Email, String Password, String PhoneNumber,
            String City, String Role, float Rating)
        {
            UserRepository.UpdateUser(Username, Email, Password, PhoneNumber, City, Role, Rating);
        }
    }
}