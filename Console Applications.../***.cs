using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("C# Harf, Rakam, Özel Karakter Sayıcı ");
        Console.WriteLine("--------------------------------------------------------");
        Console.Write("Metni Girin :");
        string str = Console.ReadLine();

        int totalCharacter = 0, totalLetterChar = 0, totalDigitChar = 0, totalSpecialChar = 0;

        char[] strArray = str.ToCharArray();
        foreach (var item in strArray)
        {
            if (char.IsDigit(item))
                totalDigitChar++;
            if (char.IsLetter(item))
                totalLetterChar++;
            if (!char.IsLetterOrDigit(item))
                totalSpecialChar++;
            totalCharacter++;
        }

        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Girilen Metin : " + str);
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Toplam Karakter Sayısı : " + totalCharacter);
        Console.WriteLine("Toplam Harf Sayısı : " + totalLetterChar);
        Console.WriteLine("Toplam Rakam Sayısı : " + totalDigitChar);
        Console.WriteLine("Toplam Özel Karakter Sayısı : " + totalSpecialChar);
        Console.WriteLine("--------------------------------------------------------");
        Console.ReadKey();
    }
}
