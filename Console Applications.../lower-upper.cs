using System;
class Program{
  static void Main(string [] args){
    Console.Write("Metin gir:");
    string metin = Console.ReadLine();
    string yeni = "";
    foreach(char c in metin){
      if(Char.IsUpper(c)){
        yeni += Char.ToLower(c);
      }else{
        yeni += Char.ToUpper(c);
      }
    }
    Console.WriteLine(yeni);
    Console.ReadKey();
  }
}
