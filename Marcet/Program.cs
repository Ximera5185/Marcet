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
            WorkProgram workProgram = new WorkProgram();
            workProgram.Run();
        }
    }
}

/*Существует продавец, он имеет у себя список товаров, и при нужде, может вам его показать, также продавец может продать вам товар. После продажи товар переходит к вам, и вы можете также посмотреть свои вещи.

Возможные классы – игрок, продавец, товар.

Вы можете сделать так, как вы видите это.*/