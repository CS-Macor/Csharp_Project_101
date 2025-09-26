using System;
namespace Pattern_26_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Pattern_26_App ===");
            int max = 7;

            // Top half of the diamond
            for (int i = 1; i <= max; i++)
            {
                Console.Write(new string(' ', max - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            // Bottom half of the diamond
            for (int i = max - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', max - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

    }
}