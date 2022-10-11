using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzalanBoslukArtanYildiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //      *
            //     **
            //    ***
            //   ****
            //  *****
            // Yukarıdaki Şekli Çizen programı yazınız...

            for (int i = 1; i < 6; i++)
            {
                for(int j = 0; j < 6 - i; j++)
                {
                    Console.Write(" ");
                }
                for(int a = 0; a < i; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
