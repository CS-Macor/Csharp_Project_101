using System;
namespace M2_Loop_Practices_Problem
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("==== Welcome to loop ===");
                Console.WriteLine("1. Home");
                Console.WriteLine("2. About us");
                Console.WriteLine("3. Contact us");
                Console.WriteLine("4. Privacy");
                Console.WriteLine("5. Exit");

            while (true)
            {
                Console.Write("Please choose Menue 1-5: Option: ");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Welcome to Home Page");
                        break;
                    case 2:
                        Console.WriteLine("Welcome to About us");
                        break;
                    case 3:
                        Console.WriteLine("Welcome to Contact us");
                        break;
                    case 4:
                        Console.WriteLine("Welcome to Privacy Page");
                        break;
                    case 5:
                        Console.Write("Are you sure to Exit now? (Y/N): ");
                        string confirm = Console.ReadLine(); 

                        if (confirm.ToUpper() == "Y")
                        {
                            Console.WriteLine("Existing Program");
                            Environment.Exit(0); 
                        }
                        else
                        {
                            Console.WriteLine("Back to Menu");
                            break; 
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input ");
                        break;
                }

            }
            Console.WriteLine();
        }
    }
}