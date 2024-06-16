using FoodSharingApp.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Controllers
{
    public class PostController
    {
        protected Boolean isPostTitleUnique(String PostTitle)
        {
            List<String> PostTitleList = PostHandler.getAllPostTitles();
            for (int i = 0; i < PostTitleList.Count; i++)
            {
                if (PostTitle.Equals(PostTitleList[i])) return false;
            }
            return true;
        }

        public String MakePost(int UserID, String PostTitle, String PostDescription, Byte[] PostImage,
            String PostLocation, DateTime FoodExpirationDate, String
            DietaryInformation)
        {
            String lbl;

            //Validasi Post Title
            if (PostTitle == null || PostTitle.Length == 0)
            {
                lbl = "Post Title cannot be null!";
                return lbl;
            }
            else if (!isPostTitleUnique(PostTitle)) 
            {
                lbl = "Post Title must be unique!";
                return lbl;
            }

            //Validasi Post Description
            if (PostDescription == null || PostDescription.Length == 0)
            {
                lbl = "Post Description cannot be null!";
                return lbl;
            }
            else if (PostDescription.Length > 150)
            {
                lbl = "Post Description cannot exceed 150!";
                return lbl;
            }

            //Validasi Location
            if (PostLocation == null  || PostLocation.Length == 0)
            {
                lbl = "Post Location cannot be null!";
                return lbl;
            }

            //Validasi FoodExpirationDate
            if (FoodExpirationDate == null) 
            {
                lbl = "Food Expiration Date cannot be null!";
                return lbl;
            }

            //Validasi Dietary Information
            if (DietaryInformation == null || DietaryInformation.Length == 0)
            {
                lbl = "Dietary Information cannot be null!";
                return lbl;
            }
            else if (DietaryInformation.Length > 150)
            {
                lbl = "Dietary Information cannot exceed 150!";
                return lbl;
            }

            //Validasi Post Image
            if (PostImage == null || PostImage.Length == 0) 
            {
                lbl = "Post Image cannot be null!";
                return lbl;
            }

            DateTime PostDate = DateTime.Now;
            PostHandler.InsertPost(UserID, PostTitle, PostDescription, PostImage, PostLocation,
                PostDate, FoodExpirationDate, DietaryInformation);
            lbl = "Post Created Successfully!";
            return lbl;
        }
    }
}