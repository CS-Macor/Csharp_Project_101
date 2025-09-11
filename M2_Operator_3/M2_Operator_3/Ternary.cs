using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Operator
{
    public static class Ternary
    {
        public static void g()
        {

            int a = 20, b = 10, res;
            res = ((a > b) ? a : b);

            Console.WriteLine("=== Ternary Operator ===");
            Console.WriteLine("Result = "+ res);
            Console.ReadKey();

        }

    }
}
