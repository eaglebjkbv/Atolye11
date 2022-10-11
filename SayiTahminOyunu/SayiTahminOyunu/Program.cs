using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1,100);
            int sayac = 5;
            Console.Write("Sayı Tahmininizi giriniz.. :" );
            int tahmin = Convert.ToInt32(Console.ReadLine());
            while (sayi != tahmin && sayac>1)
            {
                sayac--;
                if (tahmin > sayi)
                {
                    Console.WriteLine("Aşağı");
                }
                else if(tahmin<sayi)
                {
                    Console.WriteLine("Yukarı");
                }
                Console.WriteLine($"Kalan Hakkınız :{sayac}");
                Console.Write("Sayı Tahmininizi giriniz.. :");
                tahmin = Convert.ToInt32(Console.ReadLine());
            }
            if (sayac > 1)
            {
                Console.WriteLine("Tebrikler bildiniz...");
            }
            else
            {
                Console.WriteLine("Maalesef hakkınız doldu...");
            }

            
            Console.ReadKey();
        }
    }
}
