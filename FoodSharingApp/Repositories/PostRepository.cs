using FoodSharingApp.Factories;
using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Repositories
{
    public class PostRepository
    {
        private static FoodSharingAppDatabaseEntities db = DatabaseSingleton.getInstance();
        
        public static List<Post> getAllPosts()
        {
            return db.Posts.ToList();
        }
        public static List<String> getAllPostTitles()
        {
            return (from x in db.Posts select x.PostTitle).ToList();
        }
        public static Post getPostFromPostTitle(String postTitle)
        {
            return (from x in db.Posts where x.PostTitle == postTitle select x).FirstOrDefault();
        }
        public static Post getPostFromPostID(int PostID)
        {
            return (from x in db.Posts where x.PostID == PostID select x).FirstOrDefault();
        }
        public static void InsertPost(int UserID, String PostTitle, String PostDescription, Byte[] PostImage,
            String PostLocation, DateTime PostDate, DateTime FoodExpirationDate, String
            DietaryInformation)
        {
            Post post = PostFactory.Create(UserID, PostTitle, PostDescription, PostImage, PostLocation
                , PostDate, FoodExpirationDate, DietaryInformation);
            db.Posts.Add(post);
            db.SaveChanges();
        }
    }
}