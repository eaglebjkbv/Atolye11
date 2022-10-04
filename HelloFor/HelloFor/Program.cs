using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam=0;
            Console.WriteLine("Bir sayı giriniz. :");
            int deger = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= deger; i++)
            {
                toplam = toplam + i;
            }
            Console.WriteLine($"Toplam sonucu {toplam}");
            Console.ReadKey();
        }
    }
}
