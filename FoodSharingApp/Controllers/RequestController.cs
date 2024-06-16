using FoodSharingApp.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Controllers
{
    public class RequestController
    {
        protected Boolean isRequestTitleUnique(String RequestTitle)
        {
            List<String> RequestTitleList = PostHandler.getAllRequestTitles();
            for (int i = 0; i < RequestTitleList.Count; i++)
            {
                if (RequestTitle.Equals(RequestTitleList[i])) return false;
            }
            return true;
        }

        public String MakeRequest(int UserID, String RequestTitle, String RequestDescription, Byte[] RequestImage,
            String RequestLocation, DateTime FoodExpirationDate, String
            AllergenInformation)
        {
            String lbl;

            //Validasi Request Title
            if (RequestTitle == null || RequestTitle.Length == 0)
            {
                lbl = "Request Title cannot be null!";
                return lbl;
            }
            else if (!isRequestTitleUnique(RequestTitle))
            {
                lbl = "Request Title must be unique!";
                return lbl;
            }

            //Validasi Request Description
            if (RequestTitle == null || RequestTitle.Length == 0)
            {
                lbl = "Request Description cannot be null!";
                return lbl;
            }
            else if (RequestDescription.Length > 150)
            {
                lbl = "Request Description cannot exceed 150!";
                return lbl;
            }

            //Validasi Location
            if (RequestLocation == null || RequestLocation.Length == 0)
            {
                lbl = "Request Location cannot be null!";
                return lbl;
            }

            //Validasi FoodExpirationDate
            if (FoodExpirationDate == null)
            {
                lbl = "Food Expiration Date cannot be null!";
                return lbl;
            }

            //Validasi Allergen Information
            if (AllergenInformation == null || AllergenInformation.Length == 0)
            {
                lbl = "Allergen Information cannot be null!";
                return lbl;
            }
            else if (AllergenInformation.Length > 150)
            {
                lbl = "Allergen Information cannot exceed 150!";
                return lbl;
            }

            //Validasi Request Image
            if (RequestImage == null || RequestImage.Length == 0)
            {
                lbl = "Request Image cannot be null!";
                return lbl;
            }

            DateTime RequestDate = DateTime.Now;
            PostHandler.InsertRequest(UserID, RequestTitle, RequestDescription, RequestImage, RequestLocation,
                RequestDate, FoodExpirationDate, AllergenInformation);
            lbl = "Request Created Successfully!";
            return lbl;
        }
    }
}