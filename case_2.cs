using System;

class Program
{
    static void Main()
    {
        int testCaseCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCaseCount; i++)
        {
            string[] numbers = Console.ReadLine().Split();
            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);

            string str = Console.ReadLine();

            Console.WriteLine($"{num1} {num2} {str}");
        }
    }
}

Input
2
4 6
qwerty
93 123
Q1W2E3

           Output
           4 6 qwerty
           93 123 Q1W2E3
