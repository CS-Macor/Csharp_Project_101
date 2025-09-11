using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Operator
{
    public static class Arithmetic
    {
        public static void M2_Operator()
        {
            int Result;
            int Num1 = 20, Num2 = 10;
            Result = (Num1 + Num2);
            Console.WriteLine("=== Arithmetic Operator ===");
            Console.ReadKey();
            Console.WriteLine($"Additional Operator: {Result}");

            Result = (Num1 - Num2);
            Console.WriteLine($"Subtraction Operator: {Result}");

            Result = (Num1 * Num2);
            Console.WriteLine($"Multification Operator: {Result}");

            Result = (Num1 / Num2);
            Console.WriteLine($"Division Operator: {Result}");

            Result = (Num1 % Num2);
            Console.WriteLine($"Modulus Operator: {Result}");
            Console.ReadKey();

        }

    }
}
