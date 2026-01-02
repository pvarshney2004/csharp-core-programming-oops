using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.OOPs_Pillars
{
    /*
     5. Library Management System
Description: Develop a library management system:
● Use an abstract class LibraryItem with fields like itemId, title, and author.
● Add an abstract method GetLoanDuration() and a concrete method GetItemDetails().
● Create subclasses Book, Magazine, and DVD, overriding GetLoanDuration() with
specific logic.
● Implement an interface IReservable with methods ReserveItem() and
CheckAvailability().
● Apply encapsulation to secure details like the borrower’s personal data.
● Use polymorphism to allow a general LibraryItem reference to manage all items.
     */
    // Abstract class LibraryItem
    public abstract class LibraryItem
    {
        public int ItemId;
        public string Title;
        public string Author;
        public LibraryItem(int itemId, string title, string author)
        {
            ItemId = itemId;
            Title = title;
            Author = author;
        }
        public abstract int GetLoanDuration();
        public void GetItemDetails()
        {
            Console.WriteLine("Item Details:");
            Console.WriteLine($"ID: {ItemId}, Title: {Title}, Author: {Author}");
            Console.WriteLine($"Loan Duration for the item is: {GetLoanDuration()} days");
        }
    }

    // Interface IReservable
    interface IReservable
    {
        void ReserveItem();
        bool CheckAvailability();
    }

    // subclass book that implements IReservable and inherits LibraryItem
    class Book : LibraryItem, IReservable
    {
        public Book(int id, string title, string author) : base(id, title, author) { }
        public override int GetLoanDuration()
        {
            return 14; // hardcoded loan days for books
        }
        public void ReserveItem()
        {
            Console.WriteLine("Book Reserved!");
        }
        public bool CheckAvailability()
        {
            return true;
        }
    }
    // subclass book that inherits LibraryItem
    class Magazine : LibraryItem
    {
        public Magazine(int id, string title, string author) : base(id, title, author) { }
        public override int GetLoanDuration()
        {
            return 7; // hardcoded loan days for magazines
        }
    }
    // subclass book that inherits LibraryItem
    class DVD : LibraryItem
    {
        public DVD(int id, string title, string author) : base(id, title, author) { }
        public override int GetLoanDuration()
        {
            return 3; // hardcoded loan days for DVDs
        }
    }
}


