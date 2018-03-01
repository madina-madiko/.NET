using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MidtermDotnet.Models;

namespace MidtermDotnet.Models
{
    public class RouteReader : PathHelper<Route>
    {
        public string Path { get; set; }
        private List<Route> routes;

        public Route ConvertItem(string item)
        {
            var itemList = item.Split(";");
            return new Route
            {
                Id = Convert.ToInt32(itemList[0]),
                Source = itemList[1],
                Destination = itemList[2],
                DeliveryTime = Convert.ToInt32(itemList[3]),
                ShippingTypeId = Convert.ToInt32(itemList[4]),
                CategoryId = Convert.ToInt32(itemList[5])
            };
        }

        public List<Route> GetCollection()
        {
            var data = File.ReadAllLines(Path);
            if (routes == null)
            {
                routes = data
                    .Select(x => ConvertItem(x))
                    .ToList();
            }
            return routes;

        }

        public void WriteToFile(Route t)
        {
            throw new NotImplementedException();
        }
    }
}