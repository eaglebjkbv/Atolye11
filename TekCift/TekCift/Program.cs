using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekCift
{
    class Program
    {    // Klavyeden girilen sayının tek mi çift mi olduğunu bulan program
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Bir Sayı Giriniz... : ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} sayısı çifttir");
            }
            else
            {
                Console.WriteLine($"{sayi} sayısı tektir.. ");
            }
            Console.ReadKey();

        }
    }
}
