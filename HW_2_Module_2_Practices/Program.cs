// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.

//How to run your task
//task_00();

//Example of task_00
//void task_00() // is the method sample
//{
//    Console.WriteLine("Hello Task00");
//}

//////////////5 Syntax Example Questions://///////////
//create method task_1 - task_5 according task below

    //Task_1
    //Declare an integer variable named "num" and assign it the value 10. Print the value of "num" to the console.
    //Hint: Use the Console.WriteLine() method to print the value of "num".
    //Test Data:
    //Expected Output:
    //The value of num is: 10

using System;

class Program

{
    static void Main()
    //void task_1()
    {
        int num = 10;
        Console.WriteLine("The value of num is: " + num);



        //Task_2
        //Concatenate two strings, "firstName" and "lastName", and print the result.
        //Hint: Use the + operator to concatenate strings and the Console.WriteLine() method to print the result.
        //Test Data:
        //firstName = "John"
        //lastName = "Doe"
        //Expected Output:
        //The full name is: John Doe

        String firstName = "Jonhn ";
        String lastName = "Doe";
        Console.WriteLine("The full name is: " + firstName + lastName);


        //Task_3
        //Get the user's age as input and print it to the console.
        //Hint: Use the Console.ReadLine() method to get the user's input and the Console.WriteLine() method to print the result.
        //Test Data:
        //Enter your age: 25
        //Expected Output:
        //Your age is: 25
        
        Console.Write("Enter your age: ");
        string inputData = Console.ReadLine();
        int age = int.Parse(inputData);
        Console.WriteLine("Your age is: "+age);

        //Task_4
        //Calculate the sum of two integers, 5 and 7, and print the result.
        //Hint: Use the + operator to add integers and the Console.WriteLine() method to print the result.
        //Test Data:
        //Expected Output:
        //The sum of 5 and 7 is: 12

        int num1 = 5;
        int num2 = 7;
        Console.WriteLine("The sum of 5 and 7 is: "+(num1+num2));

        //Task_5
        //Convert the temperature from Celsius to Fahrenheit. Given Celsius value = 25, print the Fahrenheit equivalent.
        //Hint: Use the formula (Celsius * 9/5) + 32 to convert Celsius to Fahrenheit and the Console.WriteLine() method to print the result.
        //Test Data:
        //Celsius temperature: 25
        //Expected Output:
        //The Fahrenheit equivalent is: 77

        int celsius = 25;
        int result = (celsius * 9 / 5) + 32;
        Console.WriteLine($"If the Celsius {celsius}, The Fahrenheit equivalent is: "+ result);
    }
}

