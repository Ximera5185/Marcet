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
            Maney = _maney;
        }

        private int _maney = 500;

        private List<Product> _goods = new List<Product>();

        public List<Product> Goods { get; private set; }

        public int Maney {get; set;}

        public void AddGood(Product product)
        {
            _goods.Add(product);
        }
    }
}
