using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Operator
{
    public static class Bitwise
    {
        public static void e()
        {
            int a = 12, b = 25, Result;
            Result = a & b;
            Console.WriteLine("=== Bitwise Operator ===");  
            Console.WriteLine($"Bitwise AND: {Result}");

            Result = a | b;
            Console.WriteLine($"Bitwise OR: {Result}");

            Result = a ^ b;
            Console.WriteLine($"Bitwise XOR: {Result}");

            Console.ReadKey();

        }

    }
}
