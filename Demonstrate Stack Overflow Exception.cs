using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
class Hangman
        {
            static void excep(int value)
            {
                Console.WriteLine(value);
                excep(++value);
            }

            static void Main()
            {
                try
                {
                    excep(0);
                }
                catch (StackOverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
