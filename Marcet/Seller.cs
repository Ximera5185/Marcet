using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class Seller
    {
       public List<Product> goods = new List<Product>();

        public void ShowGoods() 
        {
            Console.Clear();

            if (goods.Count == 0)
            {
                Console.WriteLine("Список товаров у прадовца пуст");
            }
            else
            {
                foreach (Product good in goods)
                {
                    Console.WriteLine($"Список товаров продовца : ");
                    Console.WriteLine($"Порядковый номер товара - {good.SerialNumber} Название товара - {good.Name} Производитель товара - {good.Manufacturer} Цена товара - {good.Price}");
                }
            }

            Console.ReadKey();
        }

        public void Remove(Product product) 
        {
            goods.Remove( product );
        }
    }
}
