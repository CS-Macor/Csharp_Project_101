using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	struct Car
	{
		//string Make;
        public string Make;
        //string Model;
        public string Model;
    }

	enum Color
	{
		Red, Blue, Green
	}
	class program //Main method must be inside a class, not directly in namespace
    {
		static void Main(string[] args)
		{
			Car car;
			car.Make = "Toyota"; // ❌ ERROR: fields are private by default
			car.Model = "Corolla";

			//Color myColor = "Red"; // ❌ ERROR: cannot assign string to enum
			Color myColor = Color.Red;

			Console.WriteLine($"Car: {car.Make} {car.Model}, Color: {myColor}");
		}
	}
}
		