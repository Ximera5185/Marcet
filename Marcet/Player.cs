using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Goods.Add(product);

            Money -= product.Price;
        }
    }
}
