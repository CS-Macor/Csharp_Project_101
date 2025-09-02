using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T08_Errors
	{
		static void Main(string[] args)
		{
			//int num = Console.ReadLine(); // ❌ ERROR: cannot assign string to int
            int num = Convert.ToInt32(Console.ReadLine());

            //if num > 0 // ❌ ERROR: missing parentheses
            if (num > 0)

                Console.WriteLine("Positive");

			//string result = num % 2 = 0 ? "Even" : "Odd"; // ❌ ERROR: wrong operator
            string result = num % 2 == 0 ? "Even" : "Odd";

            Console.WriteLine(result);
		}
	}
}
