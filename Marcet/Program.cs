using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class Program
    {
        static void Main(string [] args)
        {
         
        }

        class Seller 
        {
           private List<string> _goods = new List<string>();

            private void SellProduct() 
            {
            
            }
        }

        class Player 
        {
            private List<string> _bag = new List<string>();
        }

        class Product 
        {
            public string Name { get; private set; }
            public string Manufacturer { get; private set; }
            public int Price { get; private set; }

            public Product(string name, string manufacturer, int price) 
            {
                Name = name;
                Manufacturer = manufacturer;
                Price = price;
            }

            private void CreateGoods() 
            {
                Product product1 = new Product("Phone","Samsung",20);
                Product product2 = new Product("television","LG",50);
                Product product3 = new Product("refrigerator","Dexp",200);
            }

            private void ShowTheGoods() { }

            private void AddGoodsList() { }

            private void RemoveGoodsList() { }
        }
    }
}
/*Существует продавец, он имеет у себя список товаров, и при нужде, может вам его показать, также продавец может продать вам товар. После продажи товар переходит к вам, и вы можете также посмотреть свои вещи.

Возможные классы – игрок, продавец, товар.

Вы можете сделать так, как вы видите это.*/