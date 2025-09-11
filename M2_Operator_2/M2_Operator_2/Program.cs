using System;

namespace M2_Operator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic();
            Assignment();
            Logical();
            Bitwise();
            Relational();
            Unary();
            Ternary();

        }

        static void Arithmetic()
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
        static void Assignment()
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
        static void Logical()
        {
            bool x = true, y = false, z;
            z = x && y;

            Console.WriteLine("=== Logical Operator ===");
            Console.WriteLine("Logical AND Operator (&&): " + z);

            z = x || y;
            Console.WriteLine("Logical OR Operator (||): " + z);

            z = !x;
            Console.WriteLine("Logical NOT Operator (!): " + z);
            Console.ReadKey();

        }
        static void Bitwise()
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
        static void Relational()
        {
            bool Result;
            int Num1 = 5, Num2 = 10;
            Result = (Num1 == Num2);

            Console.WriteLine("=== Relational Operator ===");
            Console.WriteLine("Equal to (=) Operator: " + Result);

            Result = (Num1 > Num2);
            Console.WriteLine("Greater than (>) Operator: " + Result);

            Result = (Num1 < Num2);
            Console.WriteLine("Less than (<) Operator: " + Result);

            Result = (Num1 >= Num2);
            Console.WriteLine("Greater than or Equal to (>=) Operator: " + Result);

            Result = (Num1 <= Num2);
            Console.WriteLine("Less than or Equal to (<=) Operator: " + Result);

            Result = (Num1 != Num2);
            Console.WriteLine("Not Equal to (!=) Operator: " + Result);
            Console.ReadKey();

        }
        static void Unary()
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
        static void Ternary()
        {
            int a = 20, b = 10, res;
            res = ((a > b) ? a : b);

            Console.WriteLine("=== Ternary Operator ===");
            Console.WriteLine("Result = " + res);
            Console.ReadKey();

        }
    }
}