using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Keywords.Level_01
{
    internal class Book
    {
        /*
Sample Program 2: Library Management System
Create a Book class to manage library books with the following features:
● static:
o A static variable LibraryName shared across all books.
o A static method DisplayLibraryName() to print the library name.
● this:
o Use this to initialize Title, Author, and ISBN in the constructor.
● readonly:
o Use a readonly variable ISBN to ensure the unique identifier of a book cannot
be changed.
● is operator:
o Verify if an object is an instance of the Book class before displaying its details.
         */
        // ----------static---------- 
        public static string LibraryName = "Central Library";
        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library name: "+LibraryName);
        }

        // ----------instance----------
        public string Title;
        public string Author;

        // ----------readonly---------- 
        public readonly int ISBN;

        // constructor
        public Book(string title, string author, int ISBN)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = ISBN;
        }

        // method to display book details
        public void DisplayDetails()
        {
            Console.WriteLine("Library Name: " + LibraryName);
            Console.WriteLine("ISBN Number: " + ISBN);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
        }

    }
}
