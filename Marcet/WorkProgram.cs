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
            Product product2 = new Product(2, "Машина", "Samsung", 150);
            Product product3 = new Product(3, "Клавиатура", "Samsung", 150);
            Product product4 = new Product(4, "Мышка", "Samsung", 150);

            Seller seller = new Seller();

            seller.goods.Add(product1);
            seller.goods.Add(product2);
            seller.goods.Add(product3);
            seller.goods.Add(product4);

            seller.RemoveGood(3);
            Console.ReadKey();
        }

    }
}
