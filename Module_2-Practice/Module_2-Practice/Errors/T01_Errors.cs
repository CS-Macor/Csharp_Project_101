using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class Program //T01_Errors
	{
		static void Main(string[] args)
		{
			//int age = "25"; // ❌ ERROR: assigning string to int
            int age = 25;
            //double pi = 3,14; // ❌ ERROR: wrong decimal separator
            double pi = 3.14;
            //char nameLetter = "S"; // ❌ ERROR: char must use single quotes
            char nameLetter = 'S';

            //Console.WriteLine("Age: " + Age); // ❌ ERROR: variable name mismatch
            Console.WriteLine("Age: " + age);
            //Console.WriteLine("Pi: " + Pi); // ❌ ERROR: variable name mismatch
            Console.WriteLine("Pi: " + pi);
            Console.WriteLine("Letter: " + nameLetter);
		}
	}
}
