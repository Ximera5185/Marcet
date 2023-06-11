using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class Seller
    {
        public Seller() 
        {
            Goods = _goods;
        }

        private List<Product> _goods = new List<Product>();

        public List<Product> Goods { get; private set; }

        Product product1 = new Product(1, "Теливизор", "Samsung", 150);
        Product product2 = new Product(2, "Машина", "Samsung", 150);
        Product product3 = new Product(3, "Клавиатура", "Samsung", 150);
        Product product4 = new Product(4, "Мышка", "Samsung", 150);

        public void AddGoodListSeller() 
        {
            _goods.Add(product1);
            _goods.Add(product2);
            _goods.Add(product3);
            _goods.Add(product4);
        }

        public Product SearchGood(int inputNumber, List<Product> goods)
        {
            foreach (Product good in goods)
            {
                if (good.SerialNumber == inputNumber)
                {
                    return good;
                }

            }

            return null;
        }

        public void Remove(Product product)
        {
            _goods.Remove(product);
        }
    }
}
