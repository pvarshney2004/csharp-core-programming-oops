using System;

namespace Core_Programming_OOPs.Object_Modelling
{
    /*
Problem 1: Library and Books (Aggregation)
Description: Create a Library class that contains multiple Book objects. Model the
relationship such that a library can have many books, but a book can exist independently
(outside of a specific library).
Tasks:
● Define a Library class with a List<Book> collection.
● Define a Book class with attributes such as Title and Author.
● Demonstrate the aggregation relationship by creating books and adding them to
different libraries.
Goal: Understand aggregation by modeling a real-world relationship where the Library
aggregates Book objects.
     */
    // Library class
    public class Library
    {
        public string LibraryName;
        public List<Book> Books; // Collection of Book objects (using List)
        public Library(string libraryName)
        {
            LibraryName = libraryName;
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        // Display all books in the library
        public void DisplayBooks()
        {
            Console.WriteLine($"Books in {LibraryName}:");
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();

        }
    }
    // Book class
    public class Book
    {
        public string Title;
        public string Author;
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        // Override ToString() method
        public override string ToString()
        {
            return $"{Title} by {Author}";
        }
    }
}
