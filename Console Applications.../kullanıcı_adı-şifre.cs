using System;

namespace KullaniciGirisi
{
    class Program
    {
        static void Main()
        {
            // Sabit kullanıcı adı ve şifre (test amaçlı)
            string dogruKullaniciAdi = "admin";
            string dogruSifre = "12345";

            Console.Write("Kullanıcı Adı: ");
            string kullaniciAdi = Console.ReadLine();

            Console.Write("Şifre: ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == dogruKullaniciAdi && sifre == dogruSifre)
            {
                Console.WriteLine("✅ Giriş başarılı! Hoş geldiniz, " + kullaniciAdi);
            }
            else
            {
                Console.WriteLine("❌ Hatalı kullanıcı adı veya şifre!");
            }

            Console.ReadKey();
        }
    }
}
