using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Exercises
{
	internal class T07_Exercise
	{
		static void Main(string[] args)
		{
            // TODO:
            // 1. Declare two integers
            // 2. Use arithmetic, relational, and logical operators
            // 3. Print all results

            int a = 10, b = 0;

            if (b != 0)
                Console.WriteLine("Division: " + (a / b));
            else
                Console.WriteLine("Division: cannot divide by zero");

            bool x = true, y = false;
           
            Console.WriteLine("x & y: " + (x & y));   // bitwise AND
            Console.WriteLine("x && y: " + (x && y)); // logical AND

            string? str = null;
            Console.WriteLine("Length: " + (str?.Length ?? 0));
        }
	}
}
