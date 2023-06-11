using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class Human
    {
        protected List<Product> Goods = new List<Product>();

        public int Money{get; protected set;}

        public void ShowGoods()
        {
            Console.Clear();

            if (Goods.Count == 0)
            {
                Console.WriteLine("Список товаров пуст");
            }
            else
            {
                foreach (Product good in Goods)
                {
                    Console.WriteLine($"Список товаров :");
                    Console.WriteLine($" Название товара - {good.Name} Производитель товара - {good.Manufacturer} Цена товара - {good.Price}");
                }
            }

            Console.ReadKey();
        }
    }
}
