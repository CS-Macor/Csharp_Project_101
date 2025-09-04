using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T09_Errors
	{
		static void Main(string[] args)
		{
            //for i = 1; i <= 5; i++ // ❌ ERROR: wrong for syntax
            for (int i = 1; i <= 5; i++)
            {
                //Console.WriteLine(i);
                Console.WriteLine(i);
            }

            //int j = 0;
            int j = 0;

            //while j < 5 // ❌ ERROR: missing parentheses
            while (j < 5)

                //Console.WriteLine(j++);
                Console.WriteLine(j++);
        }
	}
}
