using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class WorkProgram
    {
        public WorkProgram()
        {
            Product product1 = new Product(1, "Теливизор", "Samsung", 150);

            Seller seller = new Seller();

            seller.goods.Add(product1);
            seller.ShowGoods();
            Console.ReadKey();
        }

    }
}
