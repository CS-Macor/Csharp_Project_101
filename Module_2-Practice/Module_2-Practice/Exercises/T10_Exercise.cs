using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Exercises
{
	internal class T10_Exercise
	{
		static void Main(string[] args)
		{
			// TODO:
			// 1. Declare 2 variables
			// 2. Use nameof to print their names

			int num1 = 15;
			double num2 = 10.5;

            Console.WriteLine($"{nameof(num1)} = {num1}");
            Console.WriteLine($"{nameof(num2)} = {num2}");
        }
	}
}
