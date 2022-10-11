using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzalanYildiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // *****
            // ****
            // ***
            // **
            // *
            // Yukarıdaki şekli çizdiren programı yazınız.
            for(int i = 1; i < 6; i++)
            {
                for(int j = 0; j <6- i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}
