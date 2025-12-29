using System;
namespace Core_Programming_OOPs.Constructors.Level_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Java Constructors

            // Testing Book class
            //Book obj1 = new Book();
            //Console.WriteLine($"Title: {obj1.Title}, Author: {obj1.Author}, Price: {obj1.Price}");
            //obj1.Title = "The Great Gatsby";
            //obj1.Author = "F. Scott Fitzgerald";
            //obj1.Price = 101.99;
            //Console.WriteLine($"Title: {obj1.Title}, Author: {obj1.Author}, Price: {obj1.Price}");

            // testing circle class
            //Circle obj2_01 = new Circle();
            //Console.WriteLine($"Default Radius: {obj2_01.Radius}");
            //Circle obj2_02 = new Circle(5.5);
            //Console.WriteLine($"Parameterized Radius: {obj2_02.Radius}");

            // testing person class with copy constructor
            //Person obj3_01 = new Person("Alice", 30);
            //Console.WriteLine($"Name: {obj3_01.Name}, Age: {obj3_01.Age}");
            //Person obj3_02 = new Person(obj3_01); // Using copy constructor
            //Console.WriteLine($"Name: {obj3_02.Name}, Age: {obj3_02.Age}");

            // testing hotel booking system
            //Hotel booking1 = new Hotel();
            //Console.WriteLine($"Default Guest Name: {booking1.GuestName}, Default Room Type: {booking1.RoomType}, Nights: {booking1.Nights}");
            //Hotel booking2 = new Hotel("John Doe", "Deluxe", 3);
            //Console.WriteLine($"Guest Name: {booking2.GuestName}, Room Type: {booking2.RoomType}, Nights: {booking2.Nights}");
            //Hotel booking3 = new Hotel(booking2);
            //Console.WriteLine($"Guest Name: {booking3.GuestName}, Room Type: {booking3.RoomType}, Nights: {booking3.Nights}");

            // testing library system
            //Library obj5 = new Library("book_name", "book_author", 230);
            //Console.WriteLine($"Title: {obj5.Title}, Author: {obj5.Author}, Price: {obj5.Price}, IsAvailable: {obj5.IsAvailable}");
            //bool canBorrow = obj5.BorrowBook();
            //Console.WriteLine($"Can borrow the book: {canBorrow}");
            //Console.WriteLine("After borrowing the book:" + obj5.IsAvailable);

            // testing car rental system
            //CarRental obj6 = new CarRental("Jane Smith", "Toyota Camry", 4);
            //double totalCost = obj6.CalculateTotalCost();
            //Console.WriteLine($"Customer: {obj6.CustomerName}, Car Model: {obj6.CarModel}, Rental Days: {obj6.RentalDays}, Total Cost: {totalCost}");


            // Java Instance vs Static Class Members

            // testing product inventory
            //Product product1 = new Product("Laptop", 1200.50);
            //product1.DisplayProductDetails();
            //Product product2 = new Product("Smartphone", 799.99);
            //product2.DisplayProductDetails();
            //Product.DisplayTotalProducts();

            // testing online course management
            //OnlineCourse course1 = new OnlineCourse("C# Programming", 40, 499.99);
            //course1.DisplayCourseDetails();
            //OnlineCourse.UpdateInstituteName("Tech Academy");
            //OnlineCourse course2 = new OnlineCourse("Java Programming", 35, 399.99);
            //course2.DisplayCourseDetails();

            // testing vehicle registration
            //Vehicle vehicle1 = new Vehicle("Alice Johnson", "Sedan");
            //vehicle1.DisplayVehicleDetails();
            //Vehicle.UpdateRegistrationFee(150.00);
            //Vehicle vehicle2 = new Vehicle("Bob Smith", "SUV");
            //vehicle2.DisplayVehicleDetails();


            // C# Access Modifiers

            // Testing Student and PostgraduateStudent classes
            //Student student = new Student(101, "Alice", 9.2);
            ////Console.WriteLine(student.Name); // Error: 'Name' is protected and not accessible here
            //Console.WriteLine($"Roll Number: {student.RollNumber}, CGPA: {student.GetCGPA()}");
            //PostgraduateStudent pgStudent = new PostgraduateStudent(201, "Bob", 8.5, "Computer Science");
            //pgStudent.DisplayDetails();
            //pgStudent.SetCGPA(8.65);
            //Console.WriteLine("Updated CGPA: " + pgStudent.GetCGPA());

            // Testing BookLibrary and EBook classes
            //EBook ebook = new EBook("978-1-23-456789-0", "Learning C#", "Jane Smith", 5.5);
            //ebook.DisplayEBookDetails();
            //ebook.SetAuthor("Smith Jane");
            //Console.WriteLine("Updated Author: " + ebook.GetAuthor());

            // testing BankAccount and SavingsAccount classes
            //SavingsAccount savingsAccount = new SavingsAccount("123456789", "John Doe", 1000.0, 0.05);
            //savingsAccount.DisplayAccountDetails();
            //savingsAccount.SetBalance(1200.0);
            //Console.WriteLine("Updated Balance: " + savingsAccount.GetBalance());

            // testing Employee and Manager classes
            Manager manager = new Manager(1, "IT", 75000.0, "Project Manager");
            manager.DisplayManagerInfo();

        }
    }
}