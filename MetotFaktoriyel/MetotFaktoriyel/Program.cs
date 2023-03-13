using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotFaktoriyel
{
    class Program
    {
        static long faktoriyel(long sayi)
        {
            long f = 1;
            for (long i = 1; i <= sayi; i++)
            {
                f = f * i;
            }
            return f;
        }
        static int kuvvet(int a,int b)  
        {
            int s = 1;
            for (int i = 0; i < b; i++)
            {
                s = s * a;
            }
            return s;
        } 
        static double piYaz()
        {
            return 3.14;
        }
        static double kdvliFiyatHesapla(double f,double k)
        {
            return f + f * k / 100;
        }

        public static void Main(string[] args)
        {
            int sayi = 4;
            int us = 3;
            int sonuc = kuvvet(sayi, us); // Math.Pow(4, 3);
            Console.WriteLine($"{sayi} üssü {us} ={sonuc}");

            Console.WriteLine("Pi Sayısı={0}",piYaz());
            double fiyat=kdvliFiyatHesapla(200, 18);
            Console.WriteLine($"Ürünün Kdvli fiyatı : {fiyat}");
            Console.ReadKey();


        }
    }
}
