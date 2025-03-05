using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{      
class Program
        {
            int[,] x;
            Program()
            {
                x = new int[,] { { 11, 2, 61 }, { 42, 50, 3 } };
            }
            void printarray()
            {
                Console.WriteLine("Elements in the Given Matrix : ");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(x[i, j] + "\t");
                    }
                    Console.WriteLine("\n");
                }
            }
            int max()
            {
                int small = x[0, 0];
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (small > x[i, j])
                        {
                            small = x[i, j];
                        }
                    }
                }
                return small;
            }
            public static void Main()
            {
                Program obj = new Program();
                obj.printarray();
                Console.WriteLine("Smallest Element : {0}", obj.max());
                Console.ReadLine();
            }
        }
}
