using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace sayiyi_yaziya_cevir
{
    class Program
    {
        static void Main(string[] args)
        {
 
            int sayi, i = 0;
            do
            {
                Console.Write("Lütfen Bir Sayı Giriniz = ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi &gt; 9999 || sayi &lt; 0)
                    Console.WriteLine("Girdiğiniz Sayı 0 İle 9999 Arasında Olmalıdır !!!");
                else
                    break;
            } while (i == 1);
            Console.WriteLine("{0} Sayısı", sayi);
            switch (sayi / 1000)
            {
                case 9: Console.Write("Dokuzbin "); break;
                case 8: Console.Write("Sekizbin "); break;
                case 7: Console.Write("Yedibin "); break;
                case 6: Console.Write("Altıbin "); break;
                case 5: Console.Write("Beşbin "); break;
                case 4: Console.Write("Dörtbin "); break;
                case 3: Console.Write("Üçbin "); break;
                case 2: Console.Write("İkibin "); break;
                case 1: Console.Write("Bin "); break;
            }
            switch (sayi % 1000 / 100)
            {
                case 9: Console.Write("Dokuzyüz "); break;
                case 8: Console.Write("Sekizyüz "); break;
                case 7: Console.Write("Yediyüz "); break;
                case 6: Console.Write("Altıyüz "); break;
                case 5: Console.Write("Beşyüz "); break;
                case 4: Console.Write("Dörtyüz "); break;
                case 3: Console.Write("Üçyüz "); break;
                case 2: Console.Write("İkiyüz "); break;
                case 1: Console.Write("Yüz "); break;
            }
            switch ((sayi % 100) / 10)
            {
                case 9: Console.Write("Doksan "); break;
                case 8: Console.Write("Seksen "); break;
                case 7: Console.Write("Yetmiş "); break;
                case 6: Console.Write("Altmış "); break;
                case 5: Console.Write("Elli "); break;
                case 4: Console.Write("Kırk "); break;
                case 3: Console.Write("Otuz "); break;
                case 2: Console.Write("Yirmi "); break;
                case 1: Console.Write("On "); break;
            }
            switch ((sayi % 10))
            {
                case 9: Console.Write("Dokuz "); break;
                case 8: Console.Write("Sekiz "); break;
                case 7: Console.Write("Yedi "); break;
                case 6: Console.Write("Altı "); break;
                case 5: Console.Write("Beş "); break;
                case 4: Console.Write("Dört "); break;
                case 3: Console.Write("Üç "); break;
                case 2: Console.Write("İki "); break;
                case 1: Console.Write("Bir "); break;
            }
            if (sayi == 0)
                Console.WriteLine("Sıfır ");
            Console.Write("Şeklinde Okunur");
            Console.ReadKey();
        }
 
 
    }
}
 
