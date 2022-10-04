using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseKontor
{
    class Program
    {
        static void Main(string[] args)
        {
            int kontor = 30;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Kontör Yükleme");
                Console.WriteLine("2. Kontör Sorgulama");
                Console.WriteLine("3. Kontör gönderme ");
                Console.WriteLine("4. Çıkış");
                Console.Write("Lütfen işlem seçiniz (1--4) :");
                int sec = Convert.ToInt32(Console.ReadLine());
                switch (sec)
                {
                    case 1:
                        Console.WriteLine("Ne kadar Kontör yükleyeceksiniz.. :");
                        int yukle = Convert.ToInt32(Console.ReadLine());
                        kontor =kontor+ yukle;
                        Console.WriteLine($"Güncel Bakiyeniz {kontor} dür");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine($"Güncel Bakiyeniz : {kontor}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Gödereceğiniz numarayı Giriniz..");
                        String telNo = Console.ReadLine();
                        Console.Write("Gönderilecek kontör miktarı :");
                        int gonder = Convert.ToInt32(Console.ReadLine());
                        if (gonder <= kontor)
                        {
                            kontor = kontor - gonder;
                            Console.WriteLine("Gönderme Başarılı .... ");
                            Console.WriteLine($"Kalan Kontörünüz :{kontor}");
                        }
                        else
                        {
                            Console.WriteLine("Bakiyeniz Yetersiz !!!");
                        }
                        Console.ReadKey();         
                        break;

                }
            }

        }
    }
}
