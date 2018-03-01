using MidtermDotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermDotnet.Programs
{
    public class Collections
    {
        static readonly string routesPath = "Database/routes.csv";
        static readonly string shippingPath = "Database/shipping.csv";
        static readonly string categoriesPath = "Database/category.csv";
        static readonly string ordersPath = "Database/orders.csv";

        public static RouteReader routeC = new RouteReader { Path = routesPath };
        public static ShippingReader shippingC = new ShippingReader {Path = shippingPath};
        public static OrdersReader orderC = new OrdersReader { Path = ordersPath };
        public static CategoryReader categoryC = new CategoryReader { Path = categoriesPath };

        public static void GetAllCategoriesFromFile()
        {
            var categoriesCollection = categoryC.GetCollection();
        }

        public static void GetAllOrdersFromFile()
        {
            var ordersCollection = orderC.GetCollection();
        }
        
        public static void GetAllRoutesFromFile()
        {
            var routesCollection = routeC.GetCollection();
        }

        public static void GetAllShippingFromFile()
        {
            var shippingCollection = shippingC.GetCollection();
        }

        
    }
}