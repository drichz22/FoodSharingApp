using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Factories
{
    public class RequestOrderFactory
    {
        public static RequestOrder Create(int RequestID, DateTime RequestOrderDate, String
            RequestOrderStatus)
        {
            RequestOrder requestOrder = new RequestOrder();
            requestOrder.RequestID = RequestID;
            requestOrder.RequestOrderDate = RequestOrderDate;
            requestOrder.RequestOrderStatus = RequestOrderStatus;
            return requestOrder;
        }
    }
}