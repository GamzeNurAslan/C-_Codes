using System;
class Program{
  static void Main(string[]args){
    double taban, us, sonuc;
    Console.Write("taban:");
    taban = Convert.ToInt32(Console.ReadLine());
    Console.Write("us:");
    us = Convert.ToInt32(Console.ReadLine());
    sonuc = Math.Pow(taban, us);

    Console.WriteLine("{0} ^ {1} = {2}", taban, us, sonuc);
    Console.ReadKey();
  }
}
