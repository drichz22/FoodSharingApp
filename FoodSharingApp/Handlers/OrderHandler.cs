using FoodSharingApp.Factories;
using FoodSharingApp.Models;
using FoodSharingApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Handlers
{
    public class OrderHandler
    {
        //Request Order
        public static List<RequestOrder> getAllRequestOrders()
        {
            return RequestOrderRepository.getAllRequestOrders();
        }
        public static void InsertRequestOrder(int RequestID, DateTime RequestOrderDate, String RequestOrderStatus)
        {
            RequestOrderRepository.InsertRequestOrder(RequestID, RequestOrderDate, RequestOrderStatus); 
        }
        public static void UpdateRequestOrder(int RequestOrderID, int RequestID, DateTime RequestOrderDate,
            String RequestOrderStatus)
        {
            RequestOrderRepository.UpdateRequestOrder(RequestOrderID, RequestID, RequestOrderDate, RequestOrderStatus);
        }

        //Post Order
        public static List<PostOrder> getAllPostOrders()
        {
            return PostOrderRepository.getAllPostOrders();
        }
        public static void InsertPostOrder(int PostID, DateTime PostOrderDate, String
            PostOrderStatus)
        {
            PostOrderRepository.InsertPostOrder(PostID, PostOrderDate, PostOrderStatus);
        }
        public static void UpdatePostOrder(int PostOrderID, int PostID, DateTime PostOrderDate, String
            PostOrderStatus)
        {
            PostOrderRepository.UpdatePostOrder(PostOrderID, PostID, PostOrderDate, PostOrderStatus);
        }
    }
}