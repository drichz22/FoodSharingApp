using FoodSharingApp.Factories;
using FoodSharingApp.Models;
using FoodSharingApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Handlers
{
    public class PostHandler
    {
        //Access Post Repo
        public static List<Post> getAllPosts()
        {
            return PostRepository.getAllPosts();
        }
        public static List<String> getAllPostTitles()
        {
            return PostRepository.getAllPostTitles();
        }
        public static Post getPostFromPostTitle(String postTitle)
        {
            return PostRepository.getPostFromPostTitle(postTitle);
        }
        public static Post getPostFromPostID(int PostID)
        {
            return PostRepository.getPostFromPostID(PostID);
        }
        public static void InsertPost(int UserID, String PostTitle, String PostDescription, Byte[] PostImage,
            String PostLocation, DateTime PostDate, DateTime FoodExpirationDate, String
            DietaryInformation)
        {
            PostRepository.InsertPost(UserID, PostTitle, PostDescription, PostImage, PostLocation
                , PostDate, FoodExpirationDate, DietaryInformation);
        }

        //Access Request Repo
        public static List<Request> getAllRequests()
        {
            return RequestRepository.getAllRequests();
        }
        public static List<String> getAllRequestTitles()
        {
            return RequestRepository.getAllRequestTitles();
        }
        public static Request getRequestFromRequestTitle(String RequestTitle)
        {
            return RequestRepository.getRequestFromRequestTitle(RequestTitle);
        }
        public static Request getRequestFromRequestID(int RequestID)
        {
            return RequestRepository.getRequestFromRequestID(RequestID);
        }
        public static void InsertRequest(int UserID, String RequestTitle, String RequestDescription, Byte[] RequestImage,
            String RequestLocation, DateTime RequestDate, DateTime FoodExpirationDate, String
            AllergenInformation)
        {
            RequestRepository.InsertRequest(UserID, RequestTitle, RequestDescription, RequestImage,
                RequestLocation, RequestDate, FoodExpirationDate, AllergenInformation);
        }
    }
}