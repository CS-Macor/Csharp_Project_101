using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T06_Errors
	{
		static void Main(string[] args)
        {
            double d = 9.99;
            //int i = d; // ❌ ERROR: cannot implicitly convert double to int
            int i = Convert.ToInt32(d);

            string str = "abc";
            //int num = Convert.ToInt32(str); // ❌ ERROR: invalid string
            int num;

            if(!int.TryParse(str, out num))
            {
                Console.WriteLine($"`{str}` is not a valid number. Defaulting num = 0");
                num = 0;

            }

            Console.WriteLine("i: " + i);
            Console.WriteLine("num: " + num);
        }
	}
}
