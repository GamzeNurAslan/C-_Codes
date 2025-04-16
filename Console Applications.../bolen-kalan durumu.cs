using System;
class Program{
  static void Main(string [] args){
    int bolunen = 100, bolen = 10;
    int bolum = bolunen / bolen;
    int kalan = bolunen % bolen;
    Console.WriteLine("Bölüm = "+ bolum);
    Console.WriteLine("Kalan = "+ kalan);
    Console.ReadKey();
  }
}
