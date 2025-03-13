using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_konsol_cuma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir binary sayı girin : ");
            string binaryString = Console.ReadLine();

            try
            {
                int decimalNumber = Convert.ToInt32(binaryString, 2);
                Console.WriteLine("Decimal karşılığı : " + decimalNumber);
            }
            catch(FormatException)
            {
                Console.WriteLine("Geçersiz binary sayı girildi!");
            }
        }
    }
}
