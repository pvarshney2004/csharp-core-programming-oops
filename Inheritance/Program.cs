using System;
namespace Core_Programming_OOPs.Inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            // Creating instances of Animal subclasses
            Animal myDog = new Dog("Buddy", 3);
            Animal myCat = new Cat("Whiskers", 2);
            Animal myBird = new Bird("Tweety", 1);
            // Calling the MakeSound method on each instance
            myDog.MakeSound();
            myCat.MakeSound();
            myBird.MakeSound();
            */

            /*
            // Creating instances of Employee subclasses and displaying their information
            Employee manager = new Manager(101,"myManager",23560,10);
            manager.DisplayInfo();
            Employee developer = new Developer(102,"myDeveloper",20000,"C#");
            developer.DisplayInfo();
            Employee intern = new Intern(103,"myIntern",15000,"Half-year");
            intern.DisplayInfo();
            */

            /*
            // Creating instances of Vehicle subclasses and displaying their information
            Vehicle myCar = new Car(180, "Petrol", 5);
            myCar.DisplayInfo();
            Vehicle myBike = new Motorcycle(120, "Diesel", false);
            myBike.DisplayInfo();
            Vehicle myTruck = new Truck(140, "Diesel", 10000);
            myTruck.DisplayInfo();
            */

            // Single Inheritance Example
            // Creating an instance of Author and displaying book and author details
            //Author author = new Author("The Great Gatsby", 1925, "F. Scott Fitzgerald", "American novelist and short story writer.");
            //author.DisplayInfo();

            // Multilevel Inheritance Example
            // Creating an instance of DeliveredOrder and displaying order status
            //Order order = new Order(12345, DateTime.Now);
            //Console.WriteLine(order.GetOrderStatus());
            //ShippedOrder shippedOrder = new ShippedOrder(12345, DateTime.Now, "GU123");
            //Console.WriteLine(shippedOrder.GetOrderStatus());
            //DeliveredOrder deliveredOrder = new DeliveredOrder(12345, DateTime.Now, "GU123", DateTime.Now.AddDays(5));
            //Console.WriteLine(deliveredOrder.GetOrderStatus());

            // Hierarchical Inheritance Example
            //BankAccount acc = new BankAccount(1234,12345);
            //acc.DisplayAccountType();
            //BankAccount savAcc = new SavingsAccount(5678,67890,5.0);
            //savAcc.DisplayAccountType();
            //BankAccount checkAcc = new CheckingAccount(9101,11213,500.0);
            //checkAcc.DisplayAccountType();
            //BankAccount fixedDep = new FixedDepositAccount(1415,16171,12);
            //fixedDep.DisplayAccountType();

            // Hybrid Inheritance Example
            Chef chef = new Chef(1, "Gordon Ramsay");
            chef.PerformDuties();
            Waiter waiter = new Waiter(2, "Jamie Oliver");
            waiter.PerformDuties();

        }
    }
}