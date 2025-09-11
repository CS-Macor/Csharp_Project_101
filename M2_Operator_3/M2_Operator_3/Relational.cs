using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Operator
{
    public static class Relational
    {
        public static void c()
        {
            bool Result;
            int Num1 = 5, Num2 = 10;
            Result = (Num1 == Num2);
                 
            Console.WriteLine("=== Relational Operator ===");
            Console.WriteLine("Equal to (=) Operator: "+ Result);

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

    }
}
