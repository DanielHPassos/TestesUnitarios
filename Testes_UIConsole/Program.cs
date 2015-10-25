using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testes;

namespace Testes_UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitTest1 t = new UnitTest1();
            t.DeveFazerAumentoSalarioTI();
            Console.ReadKey();
        }
    }
}
