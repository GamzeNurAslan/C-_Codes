using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            t = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                string[] S1 = Console.ReadLine().Split();
                int A = int.Parse(S1[0]);
                int B = int.Parse(S1[1]);
                string[] S2 = Console.ReadLine().Split();
                int C = int.Parse(S2[0]);
                int D = int.Parse(S2[1]);
                int E = int.Parse(S2[2]);
                Console.WriteLine(A + " " + B + " " + C + " " + D + " " + E);
            }
        }
    }
}

Input                                      
3
1 2
3 4 5
11 22
33 44 55
1 23
456 789 101112

                 Output
                1 2 3 4 5
                11 22 33 44 55
                1 23 456 789 101112

