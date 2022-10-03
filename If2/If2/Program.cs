using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If2
{
    class Program
    {
        static void Main(string[] args)
        /* 
            * Ekranda 
            * 1.Elma
            * 2.Armut
            * 3.Kiraz
            * 4.Karpuz
            * Lüfen bir Meyve Seçiniz....
            * Seçime Göre Hangi meyveyi seçtiğini ekranda yazılacak. 
        */
        {
            while (true) { 
            Console.WriteLine("1. Elma");
            Console.WriteLine("2. Armut");
            Console.WriteLine("3. Kiraz");
            Console.WriteLine("4. Karpuz");
            Console.Write("Lütfen bir meyve seçiniz.(1..4).:");
            int secim = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (secim == 1)
            {
                Console.WriteLine("Elma seçildi");
                Console.WriteLine("Elmalar rendelenir, sonra hamura karıştırılır.");
            }else if (secim == 2)
            {

                Console.WriteLine("Armut Seçildi...");
            }else if (secim == 3)
            {
                Console.WriteLine("Kiraz Seçildi...");
            }else if (secim == 4)
            {
                Console.WriteLine("Karpuz Seçildi...");
            }
            else
            {
                Console.WriteLine("Lütfen 1 ile 4 arası bir sayı giriniz..");
            }
            Console.ReadKey();
            }

        }
    }
}
