using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int toplam = 0;
            while (sayi < 10)
            {
                sayi++;
                Console.WriteLine(sayi);
                toplam += sayi;
            }
            Console.WriteLine($"Toplam ={toplam}");
            Console.ReadKey();
        }
    }
}
