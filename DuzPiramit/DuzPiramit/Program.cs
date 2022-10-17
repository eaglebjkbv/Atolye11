using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuzPiramit
{
    class Program
    {
        static void Main(string[] args)
        {
            //   *
            //  ***
            // *****
            //*******
            // Yukarıdaki şekli çizdiren programı yazınız...
            for(int i = 0; i < 4; i++)
            {
                for(int j = 1; j < 4 - i; j++)
                {
                    Console.Write("-");
                }
                for(int z = 0; z < i * 2 + 1; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
