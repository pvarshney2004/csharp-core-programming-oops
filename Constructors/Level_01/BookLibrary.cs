using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Programming_OOPs.Constructors.Level_01
{
    public class BookLibrary
    {
        /*
Problem : Book Library System
● Design a Book class with:
o ISBN (public)
o title (protected)
o author (private)
● Implement methods to:
o Set and get the author name.
o Create a subclass EBook to access ISBN and title and demonstrate access
modifiers.
         */
        public string ISBN;
        protected string Title;
        private string author;
        // parameterized Constructor
        public BookLibrary(string isbn, string title, string authorName)
        {
            ISBN = isbn;
            Title = title;
            author = authorName;
        }
        // public method to get author name
        public string GetAuthor()
        {
            return author;
        }
        // public method to set author name
        public void SetAuthor(string authorName)
        {
            author = authorName;
        }

    }
    public class EBook : BookLibrary
    {
        public double FileSize; // in MB
        // parameterized Constructor using base keyword to call parent constructor(constructor chaining)
        public EBook(string isbn, string title, string authorName, double fileSize)
            : base(isbn, title, authorName)
        {
            FileSize = fileSize;
        }
        // method to display ebook details including protected member
        public void DisplayEBookDetails()
        {
            Console.WriteLine("EBook ISBN: " + ISBN);    // public
            Console.WriteLine("Title: " + Title);        // protected
            Console.WriteLine("Author: " + GetAuthor()); // private via public method
            Console.WriteLine("File Size: " + FileSize);
        }
    }
}
