namespace Marcet
{
    internal class Player : Human
    {
        public Player(int money = 150)
        {
            Money = money;
        }

        public void Buy(Product product)
        {
            Products.Add(product);

            Money -= product.Price;
        }

        public bool CanBuy(int price)
        {
            return Money >= price;
        }
    }
}