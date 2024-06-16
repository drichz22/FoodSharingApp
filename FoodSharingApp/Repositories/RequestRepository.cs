using FoodSharingApp.Factories;
using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Repositories
{
    public class RequestRepository
    {
        private static FoodSharingAppDatabaseEntities db = DatabaseSingleton.getInstance();

        public static List<Request> getAllRequests()
        {
            return db.Requests.ToList();
        }
        public static List<String> getAllRequestTitles()
        {
            return (from x in db.Requests select x.RequestTitle).ToList();
        }
        public static Request getRequestFromRequestTitle(String RequestTitle)
        {
            return (from x in db.Requests where x.RequestTitle == RequestTitle select x).FirstOrDefault();  
        }
        public static Request getRequestFromRequestID(int RequestID) 
        {
            return (from x in db.Requests where x.RequestID == RequestID select x).FirstOrDefault();
        }
        public static void InsertRequest(int UserID, String RequestTitle, String RequestDescription, Byte[] RequestImage,
            String RequestLocation, DateTime RequestDate, DateTime FoodExpirationDate, String
            AllergenInformation)
        {
            Request request = RequestFactory.Create(UserID, RequestTitle, RequestDescription,
                RequestImage, RequestLocation, RequestDate, FoodExpirationDate, AllergenInformation);
            db.Requests.Add(request);
            db.SaveChanges();
        }
    }
}