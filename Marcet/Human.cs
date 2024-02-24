using System;
using System.Collections.Generic;

namespace Marcet
{
    internal class Human
    {
        protected List<Product> Products = new List<Product>();

        public int Money{get; protected set;}

        public void ShowGoods()
        {
            Console.Clear();

            if (Products.Count == 0)
            {
                Console.WriteLine("Список товаров пуст");
            }
            else
            {
                foreach (Product good in Products)
                {
                    Console.WriteLine($"Список товаров :");
                    Console.WriteLine($" Название товара - {good.Name} Производитель товара - {good.Manufacturer} Цена товара - {good.Price}");
                }
            }

            Console.ReadKey();
        }
    }
}