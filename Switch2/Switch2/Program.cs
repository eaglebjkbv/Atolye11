using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     1. Üçgen alanı");
            Console.WriteLine("     2. Daire Alanı");
            Console.WriteLine("     3. Diktörgen alanı");
            Console.WriteLine("----------------------------------");
            Console.Write("Lütfen Seçimimini Giriniz (1-2) :");
            int sec = Convert.ToInt32(Console.ReadLine());
            switch (sec)
            {
                case 1:
                    Console.Write("Taban Uzunluğu Giriniz. ");
                    int t = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Yüksekliği giriniz.. :");
                    int h = Convert.ToInt32(Console.ReadLine());
                    int alan = t * h / 2;
                    Console.WriteLine("Alan ={0} cm2", alan);
                    break;
                case 2:
                    Console.Write("Yarıçapı Giriniz. :");
                    int r = Convert.ToInt32(Console.ReadLine());
                    float alanD = r * r * 3.14f;
                    Console.WriteLine($"Dairenin Alanı ={alanD} cm2");
                    break;
                case 3:
                    Console.WriteLine("A Kenarını Giriniz .:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("B Kenarını Giriniz");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int alanDiktortgen = a * b;
                    if (a != b)
                    {
                        Console.WriteLine($"Diktörgenin alanı ={alanDiktortgen}");
                    }
                    else
                    {
                        Console.WriteLine($"Karenin alanı ={alanDiktortgen}");

                    }

                    break;
                default:
                    Console.WriteLine("Lütfen 1 ya da 2 Girniz...");
                    break;
            }
            Console.ReadKey();
        }
    }
}
