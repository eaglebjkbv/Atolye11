using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonsumu
{
    class Program
    {
        static void Main(string[] args)
        {
            // type casting (Tür Dönüşümü)
            byte sayi =(byte) 3.14f;
            Console.WriteLine($"sayi ={sayi}");

            int num;
            float boy = 1.88f;
            num = (int)(boy * 100);
            Console.WriteLine(boy*100);
            Console.WriteLine($"Boyunuz : {num} dır");

            String bisey = "12";
            int say1 = Convert.ToInt32(bisey);
            Console.WriteLine($"Dönüşüm sonucu ={say1+2}");

            Console.ReadKey();
        }
    }
}
