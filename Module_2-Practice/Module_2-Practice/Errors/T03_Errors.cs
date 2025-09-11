using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T03_Errors
	{
		 static void Main(string[] args)
        {
            //var book = {Title = "C# Basics", Author = "Saroeun", Pages = 200 }; // ❌ ERROR: missing 'new' keyword
            var book = new { Title = "C# Basics", Author = "Saroeun", Pages = 200 };

            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
            Console.WriteLine("Pages: " + book.Pages);

            // book.Pages = 250; // ❌ ERROR: cannot modify anonymous type
            var updatedBook = new { book.Title, book.Author, Pages = 250 };
            Console.WriteLine($"Updated Pages: {updatedBook.Pages}");
        }
	}
}
