using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TersPiramit
{
    class Program
    {
        static void Main(string[] args)
        {
            // *******
            //  *****
            //   ***
            //    *
            // Yukarıdaki şekli çizdiren programı yazınız.
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for(int z = 0; z < (4 - i) * 2 - 1; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
