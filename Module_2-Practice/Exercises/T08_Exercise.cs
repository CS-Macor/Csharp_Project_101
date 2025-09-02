using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Exercises
{
	internal class T08_Exercise
	{
		static void Main(string[] args)
		{
            // TODO:
            // 1. Ask user to enter a number
            // 2. Check if number is positive, negative, or zero using if-else
            // 3. Use switch to print a message based on number 1-3
            // 4. Use ?: operator to print "Even" or "Odd"

            Console.Write("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)

                Console.WriteLine("This is Positive number");
            else
            {
                Console.WriteLine("This is Negative number or less than Zero");
            }

            string result = num % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(result);
        }
	}
}
