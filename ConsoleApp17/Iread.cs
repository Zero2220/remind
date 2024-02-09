using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal interface Iread
    {
        public abstract List<Product> GetAll();

        List<Product> Read();
    }
}
