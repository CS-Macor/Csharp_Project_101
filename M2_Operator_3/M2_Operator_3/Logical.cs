using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Operator
{
   public static class Logical
    {
        public static void d()
        {
            bool x = true, y = false, z;
            z = x && y;

            Console.WriteLine("=== Logical Operator ===");         
            Console.WriteLine("Logical AND Operator (&&): " +z);

            z = x || y;
            Console.WriteLine("Logical OR Operator (||): " + z);

            z = !x;
            Console.WriteLine("Logical NOT Operator (!): " + z);
            Console.ReadKey();
        }


    }
}
