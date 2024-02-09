using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Product
    {
        public Product() 
        { 
            Id=count++;
        }
        public static int count = 0;

        public static int Id = 0;
        public string Name { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Type { get; set; }
    }
}
