using System;

namespace MidtermDotnet.Models
{
    public class Orders
    {
        public int Id {get;set;}
        public int RouteId {get;set;}
        public string CategoryName {get;set;}
        public int Amount {get;set;}
        public string Status {get;set;}
    }
}