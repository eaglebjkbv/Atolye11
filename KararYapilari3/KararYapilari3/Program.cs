using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari3
{
    class Program
    {
        static void Main(string[] args)
        {
            int not1, not2, not3;
            Console.WriteLine("1.Notu Giriniz.");
            not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Notu Giriniz.");
            not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.Notu Giriniz.");
            not3 = Convert.ToInt32(Console.ReadLine());
            int ort = (not1 + not2 + not3) / 3;
            if (ort >= 0 && ort<50 )
            {
                Console.WriteLine("Notunuz E");
            }
            else if (ort >= 50 && ort < 60)
            {
                Console.WriteLine("Notunuz D");
            }
            else if (ort >= 60 && ort < 70)
            {
                Console.WriteLine("Notunuz C");
            }
            else if (ort >= 70 && ort < 85)
            {
                Console.WriteLine("Notunuz B");
            }
            else if (ort >= 85 && ort <= 100)
            {
                Console.WriteLine("Notunuz D");
            }
            else
            {
                Console.WriteLine("Lütfen doğru not giriniz....");
            }

            Console.ReadKey();
        }
    }
}
