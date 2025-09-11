using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Operator
{
    public static class Unary
    {
        public static void M2_Operator()
        {
            int x = 10;
            int Result1 = x++;
            Console.WriteLine("=== Unary Operator ===");
            Console.WriteLine("x is {0} and Result1 is {1}", x, Result1);

            int y = 10;
            int Result2 = ++y;
            Console.WriteLine("y is {0} and Result2 is {1}", y, Result2);
            Console.ReadKey();

        }

    }
}
