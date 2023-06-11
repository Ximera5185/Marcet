using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcet
{
    internal class Player
    {
        public Player()
        {
            Goods = _goods;
            Money = _money;
        }

        private readonly int _money = 150 ;

        private List<Product> _goods = new List<Product>();

        public List<Product> Goods { get; private set; }

        public int Money {get;private set;}

        public void AddGood(Product product)
        {
            _goods.Add(product);

            Money -= product.Price;
        }
     

    }
}
