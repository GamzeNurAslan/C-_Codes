using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Sınav Puanınızı Girin : ");
        int sinav = Convert.ToInt32(Console.ReadLine());
        if (sinav >= 90 && sinav <= 100)
            Console.WriteLine("AA");
        else if (sinav >= 80 && sinav < 90)
            Console.WriteLine("BA");
        else if (sinav >= 70 && sinav < 80)
            Console.WriteLine("BB");
        else if (sinav >= 60 && sinav < 70)
            Console.WriteLine("CB");
        else if (sinav >= 50 && sinav < 60)
            Console.WriteLine("CC");
        else if (sinav >= 40 && sinav < 50)
            Console.WriteLine("DC");
        else if (sinav >= 30 && sinav < 40)
            Console.WriteLine("DD");
        else if (sinav >= 0 && sinav < 30)
            Console.WriteLine("F");
        Console.ReadKey();
    }
}
