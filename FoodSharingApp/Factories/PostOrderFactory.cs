using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Factories
{
    public class PostOrderFactory
    {
        public static PostOrder Create(int PostID, DateTime PostOrderDate, String PostOrderStatus)
        {
            PostOrder postOrder = new PostOrder();
            postOrder.PostID = PostID;
            postOrder.PostOrderDate = PostOrderDate;
            postOrder.PostOrderStatus = PostOrderStatus;
            return postOrder;
        }
    }
}