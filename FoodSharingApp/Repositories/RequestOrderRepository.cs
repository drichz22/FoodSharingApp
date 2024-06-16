using FoodSharingApp.Factories;
using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Web;

namespace FoodSharingApp.Repositories
{
    public class RequestOrderRepository
    {
        private static FoodSharingAppDatabaseEntities db = DatabaseSingleton.getInstance();

        public static List<RequestOrder> getAllRequestOrders()
        {
            return db.RequestOrders.ToList();
        }
        public static void InsertRequestOrder(int RequestID, DateTime RequestOrderDate, String RequestOrderStatus)
        {
            RequestOrder requestOrder = RequestOrderFactory.Create(RequestID, RequestOrderDate, RequestOrderStatus);
            db.RequestOrders.Add(requestOrder);
            db.SaveChanges();
        }             
        public static RequestOrder FindRequestOrderByID(int RequestOrderID)
        {
            return db.RequestOrders.Find(RequestOrderID);
        }       
        public static void UpdateRequestOrder(int RequestOrderID, int RequestID, DateTime RequestOrderDate, 
            String RequestOrderStatus)
        {
            RequestOrder requestOrder = FindRequestOrderByID(RequestOrderID);
            requestOrder.RequestID = RequestID;
            requestOrder.RequestOrderDate = RequestOrderDate;
            requestOrder.RequestOrderStatus = RequestOrderStatus;
            db.SaveChanges();
        }
    }
}