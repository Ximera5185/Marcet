namespace Marcet
{
    internal class Seller : Human
    {
        private readonly int _priseProduct = 150;

        public Seller(int money = 0)
        {
            Money = money;

            int priseProduct = _priseProduct;

            CreateProducts(priseProduct);
        }

        public bool TryGetProduct(string name,out Product foundBook) 
        {
            foreach (Product  product in Products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    foundBook = product;

                    return true;
                }
            }

            foundBook = null;

            return false;
        }

        public void SellProduct(Product product)
        {
            Products.Remove(product);

            Money += product.Price;
        }

        private void CreateProducts(int priseProduct)
        {
            Products.Add(new Product("Теливизор", "Samsung", priseProduct));
            Products.Add(new Product("Машина", "Samsung", priseProduct));
            Products.Add(new Product("Клавиатура", "Samsung", priseProduct));
            Products.Add(new Product("Мышка", "Samsung", priseProduct));
        }
    }
}