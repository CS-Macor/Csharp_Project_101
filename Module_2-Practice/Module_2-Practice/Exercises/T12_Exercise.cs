using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Exercises
{
	internal class T12_Exercise
	{
		internal class T12_Exercises
		{
			static void Main(string[] args)
			{
                // TODO:
                // 1. Create string with your name
                // 2. Print length, uppercase, substring
                // 3. Replace part of string

                // 1. Create string with your name
                string name = "Khov Khunly";

                // 2. Print length, uppercase, substring
                Console.WriteLine("Original: " + name);
                Console.WriteLine("Length: " + name.Length);          
                Console.WriteLine("Uppercase: " + name.ToUpper());    
                Console.WriteLine("Substring (all 11 chars): " + name.Substring(0, 11)); 

                // 3. Replace part of string
                string replaced = name.Replace("Khov Khunly", "Khunly Khov");
                Console.WriteLine("Replaced: " + replaced);

            }
        }
	}
}
