using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Satır sayısını gir>>");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Sütun sayısını gir>>");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("===============================");
        Random rnd = new Random();

        int[,] dizi2 = new int[a, b];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                dizi2[i, j] = rnd.Next(0, 50);
                Console.Write(dizi2[i, j] + "-");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
