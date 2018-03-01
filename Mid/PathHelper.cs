using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermDotnet.Models
{
    interface PathHelper <T>
    {
        string Path { get; set; }
        List<T> GetCollection();
        T ConvertItem(string item);
    }
}