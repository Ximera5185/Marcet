using System;

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
                $"Для выхода из программы введите {ExitProgram}\n");

                switch (Console.ReadLine())
                {
                    case ShowSellerGoodsCommand:
                        _seller.ShowGoods();
                        break;

                    case ShowPlayerGoodsCommand:
                        _player.ShowGoods();
                        break;

                    case SellGoodsCommand:
                        GiveProduct();
                        break;

                    case ExitProgram:
                        isProgramWork = false;
                        break;
                }
            }
        }

        private void GiveProduct()
        {
            Product product;

            string name;

            _seller.ShowGoods();

            Console.WriteLine("Для покупки товара у продовца введите название  товара");

            name = Console.ReadLine();

            if (_seller.TryGetProduct(name, out product))
            {
                    _seller.SellProduct(product);

                    _player.AddAndBuyGood(product);   
            }
            else
            {
                Console.WriteLine("Товара с таким номером нет");
                Console.ReadKey();
            }
        }
    }
}