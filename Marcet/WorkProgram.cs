using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class WorkProgram
    {
        public void Run()
        {
            const string CaseShowSellerGoodsCommand = "1";
            const string CaseShowPlayerGoodsCommand = "2";
            const string CaseExitProgram = "6";

            Product product1 = new Product(1, "Теливизор", "Samsung", 150);
            Product product2 = new Product(2, "Машина", "Samsung", 150);
            Product product3 = new Product(3, "Клавиатура", "Samsung", 150);
            Product product4 = new Product(4, "Мышка", "Samsung", 150);

            Seller seller = new Seller();
            Player player = new Player();

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
                $"Для выхода из программы введите {CaseExitProgram}");

                switch (Console.ReadLine())
                {
                    case CaseShowSellerGoodsCommand:
                        seller.ShowGoods();
                        break;
                    case CaseShowPlayerGoodsCommand:
                        player.ShowGoods();
                        break;
                    case CaseExitProgram:
                        isProgramWork = false;
                        break;
                }
            }

        }

    }
}
