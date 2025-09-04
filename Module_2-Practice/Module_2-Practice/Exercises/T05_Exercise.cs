using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Exercises
{
    struct Car
    {
        
        public string Make;
        public string Model;
    }
    enum Color
    {
        Red, Blue, Green
    }
    class program
    {
        internal class T05_Exercise
        {
            static void Main(string[] args)
            {
                // TODO:
                // 1. Create a struct Car with properties: Make, Model
                // 2. Create an enum Color with Red, Blue, Green
                // 3. Create a Car variable and print its values along with a color

                Car car;
                car.Make = "Toyota"; 
                car.Model = "Corolla";

                Color myColor = Color.Red;
                Console.WriteLine($"Car: {car.Make} {car.Model}, Color: {myColor}");

            }
        }
    }
}
