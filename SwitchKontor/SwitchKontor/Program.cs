using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchKontor
{
    class Program
    {
        static void Main(string[] args)
        {
            int kontor = 30;
            Console.WriteLine("Kontör Yükleme   (1)");
            Console.WriteLine("Bakiye Sorgulama (2)");
            Console.WriteLine("Kontör Aktarm    (3)");
            Console.WriteLine("Lütfen seçiminizi giriniz :");
            int scm = Convert.ToInt32(Console.ReadLine());
            switch (scm)
            {
                case 1:
                    Console.WriteLine("10 Kontör 30tl  \n 20 Kontör 50tl");
                    Console.WriteLine("Kaç Kontör alacaksınız...");
                    int kontorAl = Convert.ToInt32(Console.ReadLine());
                    kontor += kontorAl;
                    Console.WriteLine($"Mevcut Bakiye ={kontor}");
                    break;
                case 2:
                    Console.WriteLine($"Mevcut Bakiyeniz ={kontor}");
                    break;
                case 3:
                    Console.WriteLine("Kontör miktarı giriniz.");
                    int kontorAktar = Convert.ToInt32(Console.ReadLine());
                    if (kontor > kontorAktar)
                    {
                        Console.WriteLine("Aktarılacak Numara ..");
                        int aktarNo = Convert.ToInt32(Console.ReadLine());
                        kontor = kontor - kontorAktar;
                        Console.WriteLine($"{kontor} kontorunuz kalmıştır...");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz kontör");
                    }
                    
                    break;

                default:
                    break;
            }
            Console.ReadKey();
        }   
    }
}
