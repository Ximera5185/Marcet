using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class TradeHandler
    {
        private Seller _seller = new Seller();
        private Player _player = new Player();

        public void Run()
        {
            const string ShowSellerGoodsCommand = "1";
            const string ShowPlayerGoodsCommand = "2";
            const string SellGoodsCommand = "3";
            const string ExitProgram = "6";

            bool isProgramWork = true;

            while (isProgramWork)
            {
                Console.Clear();
                Console.WriteLine($"Для показа списка товаров продовца {ShowSellerGoodsCommand}\n" +
                $"Для показа списка товаров покупателя {ShowPlayerGoodsCommand}\n" +
                $"Для покупки товара у продовца {SellGoodsCommand}\n" +
                $"Для выхода из программы введите {ExitProgram}\n" +
                $"Баланс игрока {_player.Money}");

                switch (Console.ReadLine())
                {
                    case ShowSellerGoodsCommand:
                        _seller.ShowGoods();
                        break;

                    case ShowPlayerGoodsCommand:
                        _player.ShowGoods();
                        break;

                    case SellGoodsCommand:
                        SellGood();
                        break;

                    case ExitProgram:
                        isProgramWork = false;
                        break;
                }
            }
        }

        private void SellGood()
        {
            Product product;
            string name;

            _seller.ShowGoods();

            Console.WriteLine("Для покупки товара у продовца введите название  товара");
            name = Console.ReadLine();

            product = _seller.SearchGood(name);

            if (product != null)
            {
                if (_player.Money >= product.Price)
                {
                    _seller.Remove(product);

                    _player.AddGood(product);
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
    }
}