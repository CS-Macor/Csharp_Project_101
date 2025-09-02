using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Exercises
{
	internal class T03_Exercise
	{
		static void Main(string[] args)
		{
            // TODO:
            // 1. Create an anonymous type for a book with properties: Title, Author, Pages
            // 2. Print all properties to the console
           
            var book = new { Title = "C# Basics", Author = "Khov Khunly", Pages = 500 };

            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
            Console.WriteLine("Pages: " + book.Pages);

            var updatedBook = new { book.Title, book.Author, Pages = 750 };
            Console.WriteLine($"Updated Pages: {updatedBook.Pages}");
        }
	}
}
