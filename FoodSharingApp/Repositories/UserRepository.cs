using FoodSharingApp.Factories;
using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Repositories
{
    public class UserRepository
    {
        private static FoodSharingAppDatabaseEntities db = DatabaseSingleton.getInstance();

        public static List<String> getAllUsernames()
        {
            return (from x in db.Users select x.Username).ToList();
        }
        public static List<User> getAllUsersWithCondition(String Role)
        {
            return (from x in db.Users where x.Role == Role select x).ToList();
        }
        public static User getUserFromUsernamePassword(String Username, String Password)
        {
            return (from x in db.Users
                    where x.Username == Username
                    && x.Password == Password
                    select x).FirstOrDefault();
        }
        public static User getUserFromUserID(int UserID)
        {
            return (from x in db.Users where x.UserID == UserID select x).FirstOrDefault();
        }
        public static User getUserFromUsername(String Username)
        {
            return (from x in db.Users where x.Username == Username select x).FirstOrDefault();
        }
        public static void InsertUser(String Username, String Email, String Password, String PhoneNumber,
            String City, String Role, float Rating)
        {
            User user = UserFactory.Create(Username, Email, Password, PhoneNumber, City, Role, Rating);
            db.Users.Add(user);
            db.SaveChanges();            
        }       
        public static void UpdateUser(String Username, String Email, String Password, String PhoneNumber,
            String City, String Role, float Rating)
        {
            User updateUser = getUserFromUsername(Username);
            updateUser.Username = Username;
            updateUser.Email = Email;
            updateUser.Password = Password;
            updateUser.PhoneNumber = PhoneNumber;
            updateUser.City = City;
            updateUser.Role = Role;
            updateUser.Rating = Rating;
            db.SaveChanges();
        }
    }
}