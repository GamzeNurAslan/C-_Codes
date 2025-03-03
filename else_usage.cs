using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 24;
            int k = 32;
            if(r > k)
            {
                Console.WriteLine("Ram is heavier than Karan.");
            }
            else if(r < k)
            {
                Console.WriteLine("Karan is heavier than Ram");
            }
            else
            {
                Console.WriteLine("Ram & Karan have the same weight!");
            }
