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
            foreach (Product good in goods)
            {
                Console.WriteLine($"Список товаров продовца : ");
                Console.WriteLine($"Порядковый номер товара - {good.SerialNumber} Название товара - {good.Name} Производитель товара - {good.Manufacturer} Цена товара - {good.Price}");
            }
        }

        public void RemoveGood(int number) 
        {
            foreach (Product good in goods)
            {
                if (number == good.SerialNumber)
                {
                    goods.Remove(good);
                    Console.WriteLine("Товар удален");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Товар с указанным серийным номером не найден.");
                }
            }
        }
    }
}
