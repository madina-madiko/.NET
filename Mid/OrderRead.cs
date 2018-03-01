using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MidtermDotnet.Models;

namespace MidtermDotnet.Models
{
    public class OrderRead : PathHelper<Orders>
    {
        public string Path { get; set; }
        private List<Orders> orders;

        public Orders ConvertItem(string item)
        {
            var itemList = item.Split(';');
            var Id = Convert.ToInt32(itemList[0]);
            var RouteId = Convert.ToInt32(itemList[1]);
            var CategoryName = itemList[2];
            var Amount = Convert.ToInt32(itemList[3]);
            var Status = itemList[4];

            return new Orders
            {
                Id = Id,
                RouteId = RouteId,
                CategoryName = CategoryName,
                Amount = Amount,
                Status = Status
            };
        }

        public List<Orders> GetCollection()
        {
            if (orders == null)
            {
                var data = File.ReadAllLines(Path);
                orders = data
                    .Select(x => ConvertItem(x))
                    .ToList();
            }
            return orders;
        }

        List<Orders> PathHelper<Orders>.GetCollection()
        {
            throw new NotImplementedException();
        }
    }
}