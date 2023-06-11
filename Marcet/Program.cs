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
            TradeHandler tradeHandler = new TradeHandler();

            tradeHandler.Run();
        }
    }
}