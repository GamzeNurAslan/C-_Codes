using System;

namespace TcUygulaması
{
    class Program
    {
        static void Main()
        {
            Console.Write("TC Kimlik No Giriniz: ");
            string tc = Console.ReadLine();

            if (tc.Length != 11 || tc[0] == '0')
            {
                Console.WriteLine("Hatalı giriş. TC 11 haneli olmalı ve ilk hanesi 0 olamaz.");
            }
            else
            {
                int toplam = 0, tekToplam = 0, ciftToplam = 0;

                for (int i = 0; i < 9; i++)
                {
                    int sayi = tc[i] - '0';
                    toplam += sayi;
                    if (i % 2 == 0)
                        tekToplam += sayi;
                    else
                        ciftToplam += sayi;
                }

                int hane10 = ((tekToplam * 7) - ciftToplam) % 10;
                int hane11 = (toplam + (tc[9] - '0')) % 10;

                if (hane10 == tc[9] - '0' && hane11 == tc[10] - '0')
                    Console.WriteLine("TC Kimlik Numarası Doğru.");
                else
                    Console.WriteLine("TC Kimlik Numarası Yanlış!");
            }

            Console.ReadKey();
        }
    }
}
