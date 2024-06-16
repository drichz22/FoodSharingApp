using FoodSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodSharingApp.Repositories
{
    public class DatabaseSingleton
    {
        private static FoodSharingAppDatabaseEntities db = null;

        public static FoodSharingAppDatabaseEntities getInstance()
        {
            if (db == null)
            {
                db = new FoodSharingAppDatabaseEntities();
            }
            return db;
        }
    }
}