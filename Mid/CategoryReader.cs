using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MidtermDotnet.Models;

namespace MidtermDotnet.Models
{
    public class CategoryReader : PathHelper<Category>
    {
        public string Path { get; set; }
        private List<Category> categories;

        public Category ConvertItem(string item)
        {
            var itemList = item.Split(";");
            return new Category
            {
                Id = Convert.ToInt32(itemList[0]),
                CategoryName = itemList[1],
                Price = Convert.ToInt32(itemList[2])
            };
        }

        public List<Category> GetCollection()
        {
            if(categories == null)
            {
                var data = File.ReadAllLines(Path);
                categories = data
                    .Select(x => ConvertItem(x))
                    .ToList();
            }
            return categories;
        }
    }
}