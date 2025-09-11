using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Exercises
{
	internal class T13_Exercise
	{
		
			static void Main(string[] args)
			{
            // TODO:
            // 1. Print all command-line arguments
            // 2. Print their count

            // 1. Print all command-line arguments
            Console.WriteLine("Command-line arguments:");
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            // 2. Print their count
            Console.WriteLine($"Total arguments: {args.Length}");
        }
		
	}
}
