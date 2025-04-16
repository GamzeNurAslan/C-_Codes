using System;
class Program{
  static void Main(string[]args){
    int number1, number2, sonuc;
    Console.Write("İlk sayı : ");
    number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("İkinci sayı : ");
    number2 = Convert.ToInt32(Console.ReadLine());

    sonuc = number1 * number2;
    Console.WriteLine("{0} * {1} = {2}", number1, number2, sonuc);
    Console.ReadKey();
  }
}
