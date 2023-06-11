using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class Product
    {
        public Product(string name,string manufacrurer,int price) 
        {
            Name = name;
            Manufacturer = manufacrurer;
            Price = price;
        }

        public string Name { get; private set; }
        public string Manufacturer { get; private set; }
        public int Price { get; private set; }
    }
}
