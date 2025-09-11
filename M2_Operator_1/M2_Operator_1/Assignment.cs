using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Operator
{
    public static class Assignment
    {
        public static void M2_Operator()
        {            
            int x = 15;
            x += 10;

            Console.WriteLine("=== Assignment Operator ===");
           
            Console.WriteLine($"Add Assignment Operator:{x}");

            x = 20;
            x -= 5;
            Console.WriteLine($"Subtract Assignment Operator:{x}");

            x = 15;
            x *= 5;
            Console.WriteLine($"Multiply Assignment Operator:{x}");

            x = 25;
            x /= 5;
            Console.WriteLine($"Division Assignment Operator:{x}");

            x = 25;
            x %= 5;
            Console.WriteLine($"Modulo Assignment Operator:{x}");
            Console.ReadKey();
        }
    }
}