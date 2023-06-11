using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class Seller : Human
    {
        public Seller(int money = 0)
        {
            Money = money;

            CreateGoods();
        }

        public Product SearchGood(string name)
        {
            foreach (Product good in Goods)
            {
                if (good.Name.ToLower() == name.ToLower())
                {
                    return good;
                }

            }

            return null;
        }

        public void Remove(Product product)
        {
            Goods.Remove(product);

            Money += product.Price;
        }

        private void CreateGoods()
        {
            Product product1 = new Product("Теливизор", "Samsung", 150);
            Product product2 = new Product("Машина", "Samsung", 150);
            Product product3 = new Product("Клавиатура", "Samsung", 150);
            Product product4 = new Product("Мышка", "Samsung", 150);

            Goods.Add(product1);
            Goods.Add(product2);
            Goods.Add(product3);
            Goods.Add(product4);
        }
    }
}
