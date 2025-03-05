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
        int m_numdiscs;
        public Program()
        {
            numdiscs = 0;
        }
        public Program(int newval)
        {
            numdiscs = newval;
        }
        public int numdiscs
        {
            get
            {
                return m_numdiscs;
            }
            set
            {
                if (value > 0)
                    m_numdiscs = value;
            }
        }
        public void movetower(int n, int from, int to, int other)
        {
            if (n > 0)
            {
                movetower(n - 1, from, other, to);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}",
                                   n, from, to);
                movetower(n - 1, other, to, from);
            }
        }
    }
    class TowersOfHanoiApp
    {
        public static int Main()
        {
            Program T = new Program();
            string cnumdiscs;
            Console.Write("Enter the number of discs: ");
            cnumdiscs = Console.ReadLine();
            T.numdiscs = Convert.ToInt32(cnumdiscs);
            T.movetower(T.numdiscs, 1, 3, 2);
            Console.ReadLine();
            return 0;
        }
}
}
