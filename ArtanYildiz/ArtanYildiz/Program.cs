using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtanYildiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // *
            // ** 
            // ***
            // ****
            // *****
            // Yukarıdaki şekli ekrana çizdiren progamı yapınız.
            for(int i = 1; i < 6; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
