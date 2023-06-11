using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class WorkProgram
    {
        Seller seller = new Seller();
        Player player = new Player();

        public void Run()
        {
            const string CaseShowSellerGoodsCommand = "1";
            const string CaseShowPlayerGoodsCommand = "2";
            const string CaseSellGoodsCommand = "3";
            const string CaseExitProgram = "6";

            bool isProgramWork = true;

            seller.AddGoodListSeller();

            while (isProgramWork)
            {
                Console.Clear();
                Console.WriteLine($"Для показа списка товаров продовца {CaseShowSellerGoodsCommand}\n" +
                $"Для показа списка товаров покупателя {CaseShowPlayerGoodsCommand}\n" +
                $"Для покупки товара у продовца {CaseSellGoodsCommand}\n" +
                $"Для выхода из программы введите {CaseExitProgram}\n" +
                $"Баланс игрока {player.Money}");

                switch (Console.ReadLine())
                {
                    case CaseShowSellerGoodsCommand:
                        ShowGoods(seller.Goods);
                        break;

                    case CaseShowPlayerGoodsCommand:
                        ShowGoods(player.Goods);
                        break;

                    case CaseSellGoodsCommand:
                        SellGood();
                        break;

                    case CaseExitProgram:
                        isProgramWork = false;
                        break;
                }
            }
           
        }

        private int GetNumber()
        {
            int inputNumber;

            Console.WriteLine("Введите число");

            while (int.TryParse(Console.ReadLine(), out inputNumber) == false)
            {
                Console.WriteLine("Ошибка ввода ! Введите целочисленное значение");
            }

            return inputNumber;
        }

        private void SellGood() 
        {
            Product product;

            int inputNumber;

            ShowGoods(seller.Goods);

            Console.WriteLine("Для покупки товара у продовца введите серийный номер товара");

            inputNumber = GetNumber();

            product = seller.SearchGood(inputNumber,seller.Goods);

            if (product != null)
            {
                if (player.Money >= product.Price)
                {
                    seller.Remove(product);

                    player.AddGood(product);

                }
                else 
                {
                    Console.WriteLine("У покупателя не достаточно средств");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Товара с таким номером нет");
                Console.ReadKey();
            }
        }

        public void ShowGoods(List<Product>goods)
        {
            Console.Clear();

            if (goods.Count == 0)
            {
                Console.WriteLine("Список товаров пуст");
            }
            else
            {
                foreach (Product good in goods)
                {
                    Console.WriteLine($"Список товаров :");
                    Console.WriteLine($"Порядковый номер товара - {good.SerialNumber} Название товара - {good.Name} Производитель товара - {good.Manufacturer} Цена товара - {good.Price}");
                }
            }

            Console.ReadKey();
        }
    }
}
