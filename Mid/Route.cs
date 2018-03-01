using System;

namespace MidtermDotnet.Models
{
    public class Route
    {
        public int Id {get;set;}
        public string Source {get; set;}
        public string Destination {get;set;}
        public int DeliveryTime {get;set;}
        public int ShippingTypeId {get;set;}
        public int CategoryId {get;set;}

    }
}