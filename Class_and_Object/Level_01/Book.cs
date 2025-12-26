using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Class_and_Object.Level_01
{
    internal class Book
    {
        public string BookTitle;
        public string BookAuthor;
        public int BookPrice;

        // Constructor to initialize book details
        public Book(string title, string author, int price)
        {
            BookTitle = title;
            BookAuthor = author;
            BookPrice = price;
        }
        // Method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine("Book Title: " + BookTitle);
            Console.WriteLine("Book Author: " + BookAuthor);
            Console.WriteLine("Book Price: " + BookPrice);
        }

    }
}
