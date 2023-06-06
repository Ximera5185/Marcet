using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class WorkProgram
    {
        const string CaseShowSellerGoodsCommand = "1";
        const string CaseShowPlayerGoodsCommand = "2";
        const string CaseSellGoodsCommand = "3";
        const string CaseExitProgram = "6";

        Seller seller = new Seller();
        Player player = new Player();

        public void Run()
        {
            Product product1 = new Product(1, "Теливизор", "Samsung", 150);
            Product product2 = new Product(2, "Машина", "Samsung", 150);
            Product product3 = new Product(3, "Клавиатура", "Samsung", 150);
            Product product4 = new Product(4, "Мышка", "Samsung", 150);

            bool isProgramWork = true;

            seller.goods.Add(product1);
            seller.goods.Add(product2);
            seller.goods.Add(product3);
            seller.goods.Add(product4);

            while (isProgramWork)
            {
                Console.Clear();
                Console.WriteLine($"Для показа списка товаров продовца {CaseShowSellerGoodsCommand}\n" +
                $"Для показа списка товаров продовца {CaseShowPlayerGoodsCommand}\n" +
                $"Для покупки товара у продовсы {CaseSellGoodsCommand}\n" +
                $"Для выхода из программы введите {CaseExitProgram}");

                switch (Console.ReadLine())
                {
                    case CaseShowSellerGoodsCommand:
                        seller.ShowGoods();
                        break;
                    case CaseShowPlayerGoodsCommand:
                        player.ShowGoods();
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

        private void SellGood() 
        {
            Product product;
            int inputNumber;

            seller.ShowGoods();

            Console.WriteLine("Для покупки товара у продовца введите серийный номер товара");

            inputNumber = Convert.ToInt32(Console.ReadLine());

            product = SearchGood(inputNumber,seller.goods);

            seller.Remove(product);

            player.AddGood(product);
        }

        private Product SearchGood(int inputNumber,List<Product>goods) 
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
    }
}
