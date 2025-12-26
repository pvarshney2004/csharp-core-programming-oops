using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Constructors.Level_01
{
    internal class Book
    {
        /*
Book Class
o Create a Book class with attributes title, author, and price.
o Provide both default and parameterized constructors.
         */
        public string Title;
        public string Author;
        public double Price;
        // Default Constructor
        public Book()
        {
            Title = "Default Title";
            Author = "Default Author";
            Price = 0.0;
        }
        // Parameterized Constructor
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
    }
}
