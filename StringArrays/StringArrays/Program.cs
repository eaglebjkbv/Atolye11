using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arabalar = {"BMW","Mercedes","Audi","Porsche","Togg","volksWagen","Tesla" };
            Console.WriteLine($"Listede {arabalar.Length} adet araba vardır");
            for (int i = 0; i < arabalar.Length; i++)
            {
                Console.WriteLine(arabalar[i]);

            }
            Console.WriteLine("----------- Sıralı Liste ------------");
            Array.Sort(arabalar);
            for (int i = 0; i < arabalar.Length; i++)
            {
                Console.WriteLine(arabalar[i]);

            }
            Console.ReadKey();
        }
    }
}
