using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T07_Errors
	{
		static void Main(string[] args)
		{
			int a = 10, b = 0;

            //Console.WriteLine("Division: " + (a / b)); // ❌ ERROR: divide by zero
            
            if (b != 0)
                Console.WriteLine("Division: " + (a / b));
            else
                Console.WriteLine("Division: cannot divide by zero");

            bool x = true, y = false;

            //Console.WriteLine("x & y: " + (x & 2)); // ❌ ERROR: invalid operands
            Console.WriteLine("x & y: " + (x & y));   // bitwise AND
            Console.WriteLine("x && y: " + (x && y)); // logical AND

            string? str = null;
			//Console.WriteLine("Length: " + str.Length); // ❌ ERROR: null reference
            Console.WriteLine("Length: " + (str?.Length?? 0));
        }
	}
}
