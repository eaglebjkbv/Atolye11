using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarYeniden
{
    class Program
    {   static void selamla()
        {
            Console.WriteLine("Amp 11A dan selamlar....");
        }
        static void selamla(string isim)
        {
            Console.WriteLine($"AMP 11 A dan selamlar ben {isim}");
        }
        static void selamla(string isim,int kere)
        {
            for(int i = 0; i < kere; i++)
            {
                Console.WriteLine(isim);
            }
        }
        static void hesapla(int sayi)
        {
            sayi = 28;
            Console.WriteLine($"Methodun içindeki a={sayi}");
        }
        static int ucgenAlanHesapla(int h,int t)
        {
            int alan = h * t / 2;
            return h;
        }
        static void Main(string[] args)
        {
            
            int alanUcgen=ucgenAlanHesapla(10, 20);
            Console.WriteLine($"Alan={alanUcgen}");

            Console.ReadKey();
        }
    }
}
