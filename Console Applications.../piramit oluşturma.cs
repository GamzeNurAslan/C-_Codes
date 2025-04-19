class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 20; i++)
            {
                for (int j = i; j < 20; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }  
            Console.ReadKey();
        }
    }
 
