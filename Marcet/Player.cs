﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class Player
    {
        public List<Product> goods = new List<Product>();

        public void ShowGoods() 
        {
            foreach (Product good in goods)
            {
                Console.WriteLine($"Список товаров игрока:");
                Console.WriteLine($"Порядковый номер товара - {good.SerialNumber} Название товара - {good.Name} Производитель товара - {good.Manufacturer} Цена товара - {good.Price}");
            }
        }
    }
}
