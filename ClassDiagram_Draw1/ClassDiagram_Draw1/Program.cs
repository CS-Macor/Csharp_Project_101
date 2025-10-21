using System;
namespace classDiagram_Draw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("=== Main Menu Option ===");
            Console.WriteLine("1. User Management");
            Console.WriteLine("2. Role Management");
            Console.WriteLine("0. Exit Program");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter Main Menu Option: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int num))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                if (num == 1)
                {
                    Console.WriteLine("=== Welcome to User Management ===");
                    Console.WriteLine();
                    Console.WriteLine("1. Add New User");
                    Console.WriteLine("2. Edit User");
                    Console.WriteLine("3. Delete User");
                    Console.WriteLine("4. View User");
                    Console.WriteLine("5. Login User");
                    Console.WriteLine("0. Back to Main Menu Option");
                    Console.WriteLine();

                    while (true)
                    {
                        Console.Write("Enter User Management Option: ");
                        string input1 = Console.ReadLine();

                        if (!int.TryParse(input1, out int num1))
                        {
                            Console.WriteLine("Invalid input.");
                            continue;
                        }

                        if (num1 == 1)
                        {
                            Console.WriteLine("1. Add New User");
                        }
                        else if (num1 == 2)
                        {
                            Console.WriteLine("2. Edit User");
                        }
                        else if (num1 == 3)
                        {
                            Console.WriteLine("3. Delete User");
                        }
                        else if (num1 == 4)
                        {
                            Console.WriteLine("4. View User");
                        }
                        else if (num1 == 5)
                        {
                            Console.WriteLine("5. Login User");
                        }
                        else if (num1 == 0)
                        {
                            //Console.WriteLine("0. Back to Main Menu");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid number, try again");
                        }
                    }
                }
                else if (num == 2)
                {
                    Console.WriteLine("=== Welcome to Role Management ===");
                    Console.WriteLine();
                    Console.WriteLine("1. Add New Role");
                    Console.WriteLine("2. Edit Role");
                    Console.WriteLine("3. Delete Role");
                    Console.WriteLine("4. View Role");
                    Console.WriteLine("0. Back to Main Menu Option");
                    Console.WriteLine();

                    while (true)
                    {
                        Console.Write("Enter Role Management Option: ");
                        string input2 = Console.ReadLine();

                         if (!int.TryParse(input2, out int num2))
                        {
                            Console.WriteLine("Invalid input.");
                            continue;
                        }

                        if (num2 == 1)
                        {
                            Console.WriteLine("1. Add New Role");
                        }
                        else if (num2 == 2)
                        {
                            Console.WriteLine("2. Edit Role");
                        }
                        else if (num2 == 3)
                        {
                            Console.WriteLine("3. Delete Role");
                        }
                        else if (num2 == 4)
                        {
                            Console.WriteLine("4. View Role");
                        }
                        else if (num2 == 0)
                        {
                            //Console.WriteLine("0. Back to Main Menu");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid number, try again");
                        }
                    }
                }

                else if (num == 0)
                {
                    while (true)
                    {
                        Console.Write($"Exit program? (Y/N): ");
                        string confirm = Console.ReadLine();

                        if (confirm?.ToUpper() == "Y")
                        {
                            Console.WriteLine($"Exited program!");
                            Environment.Exit(0);
                            break;
                        }
                        else if (confirm?.ToUpper() == "N")
                        {
                            Console.WriteLine("=== Main Menu Option ===");
                            Console.WriteLine();
                            Console.WriteLine("1. User Management");
                            Console.WriteLine("2. Role Management");
                            Console.WriteLine("0. Exit Program");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Invalid input, try again");
                        }
                    }

                }
                else
                {
                    Console.WriteLine($"Invalid number, try again");
                }
            }
        }
    }
}