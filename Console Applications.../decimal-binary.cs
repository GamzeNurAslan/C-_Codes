using System;
class Program
{
    static void Main(string[] args)
    {
        int sayi1, kalan;
        string yazikalan = "";
        Console.WriteLine("10'luk Sistemden 2'lik Sisteme Çeviren Program");
        Console.Write("Sayıyı Giriniz..:");
        sayi1 = Convert.ToInt32(Console.ReadLine());
        while (sayi1 != 0)
        {
            kalan = sayi1 % 2;
            sayi1 = sayi1 / 2;

            yazikalan = kalan.ToString() + yazikalan;
        }
        Console.WriteLine("2'lik Sistemde Karşılığı : {0}", yazikalan);

        Console.ReadKey();
    }
}
