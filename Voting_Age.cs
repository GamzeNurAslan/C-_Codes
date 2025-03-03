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

//-------------------------------------------------------//

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age = 25;
            int Vage = 18;
            
            if(Age < Vage)
            {
                Console.WriteLine("Not old enough to vote.");
                Console.Write("Wait for " + (Vage - Age) + " years");
            }
            else
            {
                Console.Write("Old enough to vote!");
            }
        }
    }
}
