using system;
class Program{
static void Main(string [] args){
  Console.Write("Hexadecimal sayıyı girin : ");
  string hexa = Console.ReadLine();

  try{
    int decimalx = Convert.ToInt32(hexa, 16);
    Console.WriteLine("Decimal karşılığı : "+decimalx);
  }catch(FormatException){
    Console.WriteLine("Geçersiz giriş!");
  }
}
}
