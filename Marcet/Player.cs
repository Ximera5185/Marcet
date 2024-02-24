using System;

namespace Marcet
{
    internal class Player : Human
    {
        public Player(int money = 150)
        {
            Money = money;
        }

        public void AddAndBuyGood(Product product)
        {
            if (Money >= product.Price)
            {
                Products.Add(product);

                Money -= product.Price;
            }
            else
            {
                Console.WriteLine("У покупателя не достаточно средств");
                Console.ReadKey();
            }

        }
    }
}