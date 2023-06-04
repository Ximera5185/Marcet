﻿using System;
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
            public List<Product> goods = new List<Product>();

        }

        class Player
        {
            public List<Product> _bag = new List<Product>();

            public void PurchaseOfGoods() { }
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
        }

        class Shop
        {
            private void WorkProgram()
            {
                Seller seller = new Seller();

                Player player = new Player();

                Product product1 = new Product("Phone", "Samsung", 20);
                Product product2 = new Product("television", "LG", 50);
                Product product3 = new Product("refrigerator", "Dexp", 200);

                const string CaseShowSellerGoodsCommand = "1";
                const string CasePurchaseOfGoodsCommand = "2";
                const string CaseShowBagOfPlayerCommand = "3";
                const string CaseWorkProgrammCommand = "4";

                bool isWorkProgram = true;

                string inputUserCommand = "";

                AddGoodsListSeller(seller.goods,product1);
                AddGoodsListSeller(seller.goods,product2);  
                AddGoodsListSeller(seller.goods,product3);

                while (isWorkProgram)
                {
                    Console.WriteLine($"Для просмотра списка товаров продовца введие {CaseShowSellerGoodsCommand}\n" +
                    $"Для покупки товара у продавца введите {CasePurchaseOfGoodsCommand}\n" +
                    $"Для просмотра своей сумки с товарами введите {CaseShowBagOfPlayerCommand}\n" +
                    $"Для выхода из программы ввежите {CaseWorkProgrammCommand}");

                    switch (inputUserCommand)
                    {
                        case CaseShowSellerGoodsCommand:
                            ShowTheGoods(seller.goods);
                            break;
                        case CasePurchaseOfGoodsCommand:
                            break;
                        case CaseShowBagOfPlayerCommand:
                            break;
                        case CaseWorkProgrammCommand:
                            break;
                    }
                }
            }

            private void AddGoodsListSeller(List<Product> goods,Product product)
            {
                goods.Add(product);
            }

            private void RemoveGoodsList() { }

            private void ShowTheGoods(List<Product> goods)
            {
                Console.Clear();

                foreach (Product good in goods)
                {
                    Console.WriteLine($"Название товара - {good.Name} Производитель товара - {good.Manufacturer} Цена товара - {good.Price}");
                }

                Console.ReadKey();
            }
        }
    }
}
/*Существует продавец, он имеет у себя список товаров, и при нужде, может вам его показать, также продавец может продать вам товар. После продажи товар переходит к вам, и вы можете также посмотреть свои вещи.

Возможные классы – игрок, продавец, товар.

Вы можете сделать так, как вы видите это.*/