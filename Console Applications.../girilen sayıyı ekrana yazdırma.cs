using System;
class Program{
  static void Main(string[]args){
    Console.Write("Bir sayı girin : ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girilen sayı {0} sayısıdır", sayi);
    Console.ReadKey();
  }
}
