using System;

namespace HomeWorkIndividual_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("==== Calculator Menu ====");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
 
            while (true)
            {
                Console.Write("Enter Your Choice (1-5): ");
                int num = Convert.ToInt32(Console.ReadLine());
                decimal num1 = 0, num2 = 0;

                if (num >= 1 && num <= 4)
                {
                    Console.Write("Enter Your First Number: ");
                    num1 = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Enter Your Second Number: ");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                }

                if (num == 1)
                {
                    Console.WriteLine($"Addition Result is: {num1 + num2}");
                }
                else if (num == 2)
                {
                    Console.WriteLine($"Subtraction Result is: {num1 - num2}");
                }
                else if (num == 3)
                {
                    Console.WriteLine($"Multiplication Result is: {num1 * num2}");
                }
                else if (num == 4)
                {
                    if (num2 != 0)
                        Console.WriteLine($"Division Result is: {num1 / num2}");
                    else
                        Console.WriteLine("Division by zero is not allowed.");
                }
                else if (num == 5)
                {
                    Console.Write("Are you sure, you want to exit? (Y/N): ");
                    string confirm = Console.ReadLine();
                    if (confirm?.ToUpper() == "Y")
                    {
                        Console.WriteLine("Exiting program");
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Back to menu\n");
                        continue; 
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Number. Please choose between 1–5.");
                }

                Console.WriteLine();
            }
        }
    }
}
