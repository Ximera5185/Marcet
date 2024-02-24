namespace Marcet
{
    internal class Player : Human
    {
        public Player(int money = 150)
        {   
            Money = money;
        }

        public void AddAndSellGood(Product product)
        {
            Products.Add(product);

            Money -= product.Price;
        }
    }
}