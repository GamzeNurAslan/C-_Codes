using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age = 25;
            int Vage = 18;
            
            if(Age >= Vage)
            {
                Console.Write("Old enough to vote!");
            }
            else
            {
                Console.Write("Not old enough to vote.");
            }
        }
    }
}
