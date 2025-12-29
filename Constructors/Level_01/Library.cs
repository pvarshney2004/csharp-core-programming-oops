using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Constructors.Level_01
{
    internal class Library
    {
        /*
Library Book System
o Create a Book class with attributes title, author, price, and availability.
o Implement a method BorrowBook() to borrow a book.
         */
        public string Title;
        public string Author;
        public double Price;
        public bool IsAvailable;
        // parameterized Constructor
        public Library(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
            IsAvailable = true; // true indicates books are available by default
        }
        // method to borrow a book
        public bool BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                return true; // borrowed
            }
            else
            {
                return false; // book not available
            }
        }
    }
}
