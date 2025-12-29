using System;
namespace Core_Programming_OOPs.Keywords.Level_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            // testing BankAccount class
            //BankAccount account1 = new BankAccount(98765,"Prashant");
            //BankAccount account2 = new BankAccount(12345, "Varshney");
            //BankAccount.GetTotalAccounts();
            //if(account1 is  BankAccount)
            //{
            //    Console.WriteLine("Account Details:");
            //    account1.DisplayDetails();
            //}
            //else
            //{
            //    Console.WriteLine("Object is not a BankAccount");
            //}

            // testing Book class
            //Book book = new Book("csharp-programming", "jame hopper", 1232454);
            //if(book is Book)
            //{
            //    Console.WriteLine("Book Details: ");
            //    book.DisplayDetails();
            //}

            // testing Employee class
            //Employee emp = new Employee("Rahul", "HR", 101);
            //if(emp is Employee)
            //{
            //    Console.WriteLine("Employee Details: ");
            //    emp.DisplayDetails();
            //}
            //else
            //{
            //    Console.WriteLine("Object is not a Employee");
            //}

            //testing Product class
            //Product p = new Product("abc",123,2,101);
            //if(p is Product)
            //{
            //    Console.WriteLine("Product Details: ");
            //    p.DisplayDetails();
            //}
            //else
            //{
            //    Console.WriteLine("Object is not a Product");
            //}

            //testing Student class
            //Student s = new Student("Rahul",34,'A');
            //Student s2 = new Student("RahulB",43,'B');
            //Student.DisplayTotalStudents();
            //if(s is Student)
            //{
            //    Console.WriteLine("Student Details: ");
            //    s.DisplayDetails();
            //}
            //else
            //{
            //    Console.WriteLine("Object is not a Student");
            //}

            // testing vehicle class
            //Vehicle v = new Vehicle("TVS", "Bike", 123435);
            //if(v is Vehicle)
            //{
            //    Console.WriteLine("Vehicle Details: ");
            //    v.DisplayDetails();
            //}
            //Console.WriteLine("Vehicle Registration fee: "+Vehicle.RegistrationFee);
            //Vehicle.UpdateRegistrationFee(2000);
            //Console.WriteLine("Updated Vehicle Registration fee: " + Vehicle.RegistrationFee);
            
            //testing Patient class
            Patient v = new Patient(101,"abc","fever",23);
            if(v is Patient)
            {
                Console.WriteLine("Patient Details: ");
                v.DisplayDetails();
            }            
        }
    }
}