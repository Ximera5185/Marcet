namespace Marcet
{
    internal class Player : Human
    {
        public Player(int money = 150)
        {   
            Money = money;
        }

        public void AddGood(Product product)
        {
            _products.Add(product);

            Money -= product.Price;
        }
    }
}