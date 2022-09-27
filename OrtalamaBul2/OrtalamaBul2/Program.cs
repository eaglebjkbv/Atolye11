using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaBul2
{
    class Program
    {
        static void Main(string[] args)
        {
            int not1, not2, not3;
            Console.WriteLine("==== Not Ortalaması Bulma Programı ====");
            Console.Write("1. Notu Griniz..:");
            not1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Notu Griniz..:");
            not2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Notu Griniz..:");
            not3 = Convert.ToInt32(Console.ReadLine());
            int ort = (not1 + not2 + not3) / 3;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1.Not    2.Not     3.Not");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"  {not1}      {not2}       {not3}");
            Console.WriteLine($"Nolarınızın ortalaması : {ort}");

            bool durum = ort > 50;
            Console.WriteLine("Geçti / Kaldı : "+durum);

            
            Console.ReadKey();

        }              
    }
}
