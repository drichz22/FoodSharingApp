using FoodSharingApp.Factories;
using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Repositories
{
    public class PostOrderRepository
    {
        private static FoodSharingAppDatabaseEntities db = DatabaseSingleton.getInstance();

        public static List<PostOrder> getAllPostOrders()
        {
            return db.PostOrders.ToList();
        }
        public static void InsertPostOrder(int PostID, DateTime PostOrderDate, String
            PostOrderStatus)
        {
            PostOrder postOrder = PostOrderFactory.Create(PostID, PostOrderDate, PostOrderStatus);
            db.PostOrders.Add(postOrder);
            db.SaveChanges();
        }      
        public static PostOrder FindPostOrderByID(int PostID)
        {
            return db.PostOrders.Find(PostID);
        }
        public static void UpdatePostOrder(int PostOrderID, int PostID, DateTime PostOrderDate, String
            PostOrderStatus)
        {
            PostOrder postOrder = FindPostOrderByID(PostOrderID);
            postOrder.PostOrderID = PostID;
            postOrder.PostOrderDate = PostOrderDate;
            postOrder.PostOrderStatus = PostOrderStatus;
            db.SaveChanges();
        }
    }
}