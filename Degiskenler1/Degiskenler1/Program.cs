using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte yas=16;
            Console.WriteLine($"Yaş ={yas}");
            
            short bisikletfiyati=3000;
            Console.WriteLine("Bisikletin fiyatı ={0}",bisikletfiyati);

            long nufus = 2000000000000000000;
            Console.WriteLine($"Hindistanın gelecekteki Nüfusu ={nufus}");

            float PI = 3.14f;
            Console.WriteLine($"Pi sayısı {PI} dür");

            double avagadroSayisi = 6.022394297;
            Console.WriteLine("Avagadro Sayısı {0} dır",avagadroSayisi);

            char basHarf = 'B';
            Console.WriteLine($"İsmimin ilk harfi {basHarf} dir" );

            String isim = "Bülent";
            Console.WriteLine($"Benim adım {isim} dir adımın uzunluğu {isim.Length} dir");

            bool durum = true;
            Console.WriteLine($"Durmumuz ={durum}");

            Console.ReadKey();
        }
    }
}
