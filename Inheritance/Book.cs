using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Inheritance
{
    /*
     Sample Problem 1: Library Management with Books and Authors
○ Description: Model a Book system where Book is the superclass, and Author
is a subclass.
○ Tasks:
■ Define a superclass Book with attributes like Title and
PublicationYear.
■ Define a subclass Author with additional attributes like Name and Bio.
■ Create a method DisplayInfo() to show details of the book and its
author.
○ Goal: Practice single inheritance by extending the base class and adding more
specific details in the subclass.
     */
    // Superclass
    public class Book
    {
        public string Title;
        public int PublicationYear;
        public Book(string Title, int PublicationYear)
        {
            this.Title = Title;
            this.PublicationYear = PublicationYear;
        }
    }
    // Subclass(Author)
    public class Author : Book 
    {
        public string Name;
        public string Bio;

        public Author(string Title, int publicationYear, string name, string bio) : base(Title, publicationYear)
        {
            Name = name;
            Bio = bio;
        }
        // method to display info
        public void DisplayInfo()
        {
            Console.WriteLine("Book Details: ");
            Console.WriteLine($"Title: {Title}, Publication Year: {PublicationYear}");
            Console.WriteLine("Author Details: ");
            Console.WriteLine($"Name: {Name}, Bio: {Bio}");
        }
    }
}
