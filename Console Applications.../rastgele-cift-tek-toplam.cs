using System;
static void Main(string[] args)
{
    int sayi, tekAdet = 0, ciftAdet = 0;
    Random rnd = new Random();
    for (int i = 1; i <= 10; i++)
    {
        sayi = rnd.Next(1, 100);
        Console.WriteLine(sayi);
        if (sayi % 2 == 0)
        {
            ciftAdet++;
        }
        else
        {
            tekAdet++;
        }
    }
    Console.WriteLine("Çift Sayı Adeti : {0}", ciftAdet);
    Console.WriteLine("Tek Sayı Adeti : {0}", tekAdet);
    Console.ReadKey();
}
