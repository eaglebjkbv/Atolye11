using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtanBoslukAzalanYildiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // *****
            //  ****
            //   ***
            //    **
            //     *
            // Yukarıdaki Şekli çizdiren programı yazınız.
            for(int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for(int a = 0; a < 6 - i; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}