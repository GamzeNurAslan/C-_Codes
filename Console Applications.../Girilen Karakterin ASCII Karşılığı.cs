using System;
class Program{
static void Main(string[] args)
        {
            char c;
            Console.Write("Karakter Girin: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(c+ " karakteri ASCII Kaşılığı >> " + Convert.ToInt32(c));
            Console.ReadKey();
        }
}
