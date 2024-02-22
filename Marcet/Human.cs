using System;
using System.Collections.Generic;

namespace Marcet
{
    internal class Human
    {
        protected List<Product> _products = new List<Product>();

        public int Money{get; protected set;}

        public void ShowGoods()
        {
            Console.Clear();

            if (_products.Count == 0)
            {
                Console.WriteLine("Список товаров пуст");
            }
            else
            {
                foreach (Product good in _products)
                {
                    Console.WriteLine($"Список товаров :");
                    Console.WriteLine($" Название товара - {good.Name} Производитель товара - {good.Manufacturer} Цена товара - {good.Price}");
                }
            }

            Console.ReadKey();
        }
    }
}