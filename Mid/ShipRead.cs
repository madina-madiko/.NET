using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MidtermDotnet.Models;

namespace MidtermDotnet.Models
{
    public class ShipRead : PathHelper<ShipType>
    {
        public string Path { get; set; }
        private List<ShipType> types;

        public ShipType ConvertItem(string item)
        {
            var itemList = item.Split(";");
            return new ShipType
            {
                Id = Convert.ToInt32(itemList[0]),
                ShippingName = itemList[1]
            };
        }

        public List<ShipType> GetCollection()
        {
            if(types== null)
            {
                var data = File.ReadAllLines(Path);
                types = data
                    .Select(x => ConvertItem(x))
                    .ToList();
            }
            return types;
        }
    }
}
