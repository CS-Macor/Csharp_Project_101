using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Exercises
{
	internal class T06_Exercise
	{
		static void Main(string[] args)
		{
            // TODO:
            // 1. Convert a double to int (explicit)
            // 2. Convert a string to double using Convert class
            // 3. Print all results

            double d = 9.99;
            int i = Convert.ToInt32(d);
            string str = "abc";

            int num;
            if (!int.TryParse(str, out num))
            {
                Console.WriteLine($"`{str}` is not a valid number. Defaulting num = 0");
                num = 0;
            }

            Console.WriteLine("i: " + i);
            Console.WriteLine("num: " + num);
        }
    }
}

	