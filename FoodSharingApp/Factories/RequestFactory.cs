using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Factories
{
    public class RequestFactory
    {
        public static Request Create(int UserID, String RequestTitle, String RequestDescription, Byte[] RequestImage,
            String RequestLocation, DateTime RequestDate, DateTime FoodExpirationDate, String
            AllergenInformation)
        {
            Request request = new Request();
            request.UserID = UserID;
            request.RequestTitle = RequestTitle;
            request.RequestDescription = RequestDescription;
            request.RequestImage = RequestImage;
            request.RequestLocation = RequestLocation;
            request.RequestDate = RequestDate;
            request.FoodExpirationDate = FoodExpirationDate;
            request.AllergenInformation = AllergenInformation;
            return request;
        }
    }
}