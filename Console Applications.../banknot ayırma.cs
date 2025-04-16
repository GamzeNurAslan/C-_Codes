using System;

class Program
{
    static void Main(string[] args)
    {
        int[] banknot = { 200, 100, 50, 20, 10, 5, 1 };
        int para, adet;

        Console.Write("Ödenecek tutarı girin : ");
        para = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("==========================");

        for (int i = 0; i <= 6; i++)
        {
            adet = para / banknot[i];

            if (adet != 0)
                Console.WriteLine(adet + " adet : " + banknot[i] + " TL");

            para %= banknot[i];
        }

        Console.ReadKey();
    }
}
