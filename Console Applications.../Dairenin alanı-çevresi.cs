using System;
class Program{
  static void Main(string [] args){
    const double pi = 3.14;
    double r, cevre, alan;
    Console.Write("r:");
    r = Convert.ToDouble(Console.ReadLine());

    alan = pi * r * r;
    cevre = 2 * pi * r;

    Console.WriteLine("Dairenin Alanı :"+alan);
    Console.WriteLine("Dairenin Çevresi :"+cevre); 
    Console.ReadKey();
  }
}
