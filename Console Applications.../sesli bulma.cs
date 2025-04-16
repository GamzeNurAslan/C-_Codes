using System;
class Program
{
    static void Main(string[] args)
    {
        string metin = "Merhaba Dünya, bu örnek bir program";
        string sesli = "aeıioöuü";

        int sayac = 0;
        for (int i = 0; i < metin.Length; i++)
        {
            if (sesli.Contains(metin[i]))
            {
                sayac++;
            }
        }
        Console.WriteLine(metin);
        Console.WriteLine("Yukarıdaki ifadede toplam {0} \ntane sesli harf vardır.", sayac);
        Console.ReadLine();
    }
}
