using System;
class Program{
static void Main(string[] args)
{
    Console.Write("A Değerini Giriniz = ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("B Değerini Giriniz = ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("C Değerini Giriniz = ");
    int c = Convert.ToInt32(Console.ReadLine());
    double d = (b * b) - (4 * a * c);
    if (d > 0)
    {
        double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
        double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
        Console.WriteLine("Denklemin İki Kökü Vardır = ");
        Console.WriteLine("x1 =" + x1);
        Console.WriteLine("x2 =" + x2);
    }
    else if (d == 0)
    {
        double x = -b / (2 * a);
        Console.WriteLine("Denklemin Bir Kökü Vardır = ");
        Console.WriteLine("x =" + x);
    }
    else
    {
        Console.Write("Sanal Kök Vardır");
    }
    Console.ReadKey();
}
}
