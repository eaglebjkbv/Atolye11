using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari1
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
            if (ort >= 50)
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }
            
            Console.ReadKey();

        }
    }
}
