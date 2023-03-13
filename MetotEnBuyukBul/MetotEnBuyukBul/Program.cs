using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotEnBuyukBul
{
    class Program
    {
        static int maxBul(int[] gelenSayilar)
        {
            int max = gelenSayilar[0];
            for(int i = 1; i < gelenSayilar.Length; i++)
            {
                if (max < gelenSayilar[i])
                {
                    max = gelenSayilar[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            {
                //int[] sayilar = new int[5];
                //sayilar[0] = 78;
                //sayilar[1] = 123;
                //sayilar[2] = 524;
                //sayilar[3] = 38;
                //sayilar[4] = 11;
            }
            int[] sayilar = {78,123,524,38,11,1025,678,34535};
            int enbuyuk = maxBul(sayilar);
            Console.WriteLine("Dizideki en büyük sayi ={0}",enbuyuk);
            Console.ReadKey();
            int sonuc = faktoriyel(10);
            Console.WriteLine($"Faktoriyel Sonucu :{sonuc}");
        }
    }
}
