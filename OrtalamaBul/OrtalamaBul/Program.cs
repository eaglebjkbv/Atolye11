using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaBul
{
    class Program
    {
        static void Main(string[] args)
        {
            int not1, not2, not3;
            not1 = 60;
            not2 = 70;
            not3 = 30;
            int ort = (not1 + not2 + not3) / 3;
            Console.WriteLine($"Notlarınızın ortalaması : {ort}");
            Console.ReadKey();
        }
    }
}
