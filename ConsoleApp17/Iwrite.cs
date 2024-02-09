using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal interface Iwrite
    {
        public  abstract void AddProduct(Product product);
        public abstract void AddProducts(List<Product> products);
        

        public abstract void  RemoveById();

        public abstract void UpdateById();
    }
}
