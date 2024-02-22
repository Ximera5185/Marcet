namespace Marcet
{
    internal class Seller : Human
    {
        private readonly int _priseProduct = 150;

        public Seller(int money = 0)
        {
            Money = money;

            int priseProduct = _priseProduct;

            CreateGoods(priseProduct);
        }

        public Product TryGetProduct(string name)
        {
            foreach (Product product in _products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    return product;
                }

            }

            return null;
        }

        public void Sell(Product product)
        {
            _products.Remove(product);

            Money += product.Price;
        }

        private void CreateGoods(int priseProduct)
        {
            _products.Add(new Product("Теливизор", "Samsung", priseProduct));
            _products.Add(new Product("Машина", "Samsung", priseProduct));
            _products.Add(new Product("Клавиатура", "Samsung", priseProduct));
            _products.Add(new Product("Мышка", "Samsung", priseProduct));
        }
    }
}