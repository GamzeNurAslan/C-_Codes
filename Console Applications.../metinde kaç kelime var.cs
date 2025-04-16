using System;
class Program{
  static void Main(string [] args){
    Console.Write("Metin girin:");
    string metin = Console.ReadLine();
    string [] words = metin.Split(' ');
    Console.WriteLine("Kelimeler:"+words.Length);
    Console.ReadKey();
  }
}
