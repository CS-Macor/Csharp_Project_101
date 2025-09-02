using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Exercises
{
	internal class T11_Exercise
	{
		static void Main(string[] args)
		{
            // TODO:
            // 1. Create one-dimensional array of names
            // 2. Print each using foreach
            // 3. Create 2D array and print element
            // 4. Create jagged array and print element
            
            // 1. Create one-dimensional array of names
            string[] provinces = { "Phnom Penh", "Siemreap", "Prey Veng" };

            // 2. Print each using foreach
            Console.WriteLine("One-dimensional array (foreach):");
            foreach (string name in provinces)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            // 3. Create 2D array and print element
            int[,] numbers2D =
            {

            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }

            };

            Console.WriteLine("2D array element at [1,2]: " + numbers2D[1, 2]); 
            Console.WriteLine();

            // 4. Create jagged array and print element
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 10, 20 };
            jaggedArray[1] = new int[] { 30, 40, 50 };
            jaggedArray[2] = new int[] { 60 };

            Console.WriteLine("Jagged array element at [1][2]: " + jaggedArray[1][2]); 
        }
	}
}
