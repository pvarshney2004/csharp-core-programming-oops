using System;
namespace Core_Programming_OOPs.OOPs_Pillars
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<Employee> employees = new List<Employee>();
            employees.Add(new FullTimeEmployee(101,"Raj",12000,12));
            employees.Add(new PartTimeEmployee(102,"yash",8000,20));
            employees[0].AssignDepartment("IT");
            employees[1].AssignDepartment("Sales");
            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();
            }
            */

            //List<Product> products = new List<Product>();
            //products.Add(new Electronics(201, "Laptop", 50000));
            //products.Add(new Clothing(202, "T-Shirt", 1000));
            //products.Add(new Groceries(203, "Rice", 200));
            //foreach(Product p in products)
            //{
            //    p.PrintFinalPrice(p);
            //}

            //List<Vehicle> vehicles = new List<Vehicle>();
            //vehicles.Add(new Car("KA01AB1234", 1500, "INS12345"));
            //vehicles.Add(new Bike("KA02CD5678", 800, "INS99999"));
            //vehicles.Add(new Car("KA03EF9012", 2000, "INS67890"));
            //foreach (Vehicle v in vehicles)
            //{
            //    double rentalCost = v.CalculateRentalCost(5);
            //    Console.WriteLine("Vehicle Details:");
            //    Console.WriteLine("Vehicle Number: " + v.VehicleNumber);
            //    Console.WriteLine("Type: " + v.Type);
            //    Console.WriteLine("Rental Cost: " + rentalCost);
            //    if (v is IInsurable i)
            //    {
            //        Console.WriteLine("Insurance Details: " + i.GetInsuranceDetails());
            //        Console.WriteLine("Insurance Cost: " + i.CalculateInsurance());
            //        Console.WriteLine();
            //    }
            //}


            /*
            List<BankAccount> accounts = new List<BankAccount>
            {
                new SavingsAccount(101, "Alice", 80000),
                new CurrentAccount(102, "Bob", 40000)
            };
            foreach (BankAccount account in accounts)
            {
                account.DisplayDetails();
                if (account is ILoanable loanableAcc)
                {
                    Console.WriteLine("Applying for loan...");
                    loanableAcc.ApplyForLoan(50000);
                    bool isEligible = loanableAcc.CalculateLoanEligibility();
                    if(isEligible)
                    {
                        Console.WriteLine("Congrats! Loan approved!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, Loan denied.");
                    }
                }
                Console.WriteLine();
            }
            */

            /*
            List<LibraryItem> items = new List<LibraryItem>
            {
                new Book(1, "C# Basics", "John"),
                new Magazine(2, "Tech Monthly", "Editor"),
                new DVD(3, "Learning OOP", "Author")
            };
            foreach (LibraryItem item in items)
            {
                item.GetItemDetails();
                if (item is IReservable reservable)
                {
                    Console.WriteLine("Available: " + reservable.CheckAvailability());
                    reservable.ReserveItem();
                }
            }
            */


            //List<FoodItem> foodItems = new List<FoodItem>
            //{
            //    new VegItem("Kadai Paneer", 200, 2),
            //    new NonVegItem("Kawaab", 300, 1)
            //};
            //foreach (FoodItem item in foodItems)
            //{
            //    item.GetItemDetails();
            //    if (item is IDiscountable discount)
            //    {
            //        Console.WriteLine(discount.GetDiscountDetails());
            //        Console.WriteLine("Discount: " + discount.ApplyDiscount());
            //    }
            //    Console.WriteLine();
            //}

            
            List<Patient> patients = new List<Patient>();
            patients.Add(new InPatient(101, "Kamal", 34));
            patients.Add(new OutPatient(102, "Komal", 43));
            foreach (Patient patient in patients)
            {
                patient.GetPatientDetails();
                if (patient is IMedicalRecord record)
                {
                    record.AddRecord("General Checkup Completed");
                    record.ViewRecords();
                }
                Console.WriteLine();
            }
            



        }
    }
}