using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Factories
{
    public class PostFactory
    {
        public static Post Create(int UserID, String PostTitle, String PostDescription, Byte[] PostImage,
            String PostLocation, DateTime PostDate, DateTime FoodExpirationDate, String
            DietaryInformation)
        {
            Post post = new Post();
            post.UserID = UserID;
            post.PostTitle = PostTitle;
            post.PostDescription = PostDescription;
            post.PostImage = PostImage;
            post.PostLocation = PostLocation;
            post.PostDate = PostDate;
            post.FoodExpirationDate = FoodExpirationDate;
            post.DietaryInformation = DietaryInformation;
            return post;
        }
    }
}