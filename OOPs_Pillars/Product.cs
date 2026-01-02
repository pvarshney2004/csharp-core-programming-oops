using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.OOPs_Pillars
{
    /*
     2. E-Commerce Platform
Description: Develop a simplified e-commerce platform:
● Create an abstract class Product with fields like productId, name, and price, and an
abstract method CalculateDiscount().
● Extend it into concrete classes: Electronics, Clothing, and Groceries.
● Implement an interface ITaxable with methods CalculateTax() and GetTaxDetails() for
applicable product categories.
● Use encapsulation to protect product details, allowing updates only through setter
methods.
● Showcase polymorphism by creating a method that calculates and prints the final price
(price + tax - discount) for a list of products.
     */
    // Abstract Product class
    public abstract class Product
    {
        public int ProductID;
        public string Name;
        private double price;

        public Product(int productID, string name, double price)
        {
            ProductID = productID;
            Name = name;
            Price = price;
        }

        // validating price through encapsulation
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Price cannot be negative.");
                }
                price = value;
            }
        }
        public abstract double CalculateDiscount();

        public void PrintFinalPrice(Product p) 
        {
                double tax = 0; // initially no tax
                if(p is ITaxable t)
                {
                    tax = t.CalculateTax();
                    Console.WriteLine(t.GetTaxDetails());
                }
                double discount = p.CalculateDiscount();
                double FinalPrice = p.Price + tax - discount;
                Console.WriteLine($"Final price for {p.Name} is: {FinalPrice}");
                Console.WriteLine();
        }
    }

    // Concrete Electronics class that extends Product and implements ITaxable
    public class Electronics : Product, ITaxable
    {
        public Electronics(int productID, string name, double price) : base(productID, name, price)
        {
        }
        private double taxRate = 0.08; // 8% tax
        private double discountRate = 0.10; // 10% discount

        public override double CalculateDiscount()
        {
            return Price * discountRate;
        }
        public double CalculateTax()
        {
            return Price * taxRate; 
        }
        public string GetTaxDetails()
        {
            return $"Tax on electronics items is: {taxRate}%.";
        }
    }
    // Concrete Clothing class that extends Product and implements ITaxable
    public class Clothing : Product, ITaxable
    {
        public Clothing(int productID, string name, double price) : base(productID, name, price)
        {
        }
        private double taxRate = 0.1; // 10% tax
        private double discountRate = 0.15; // 15% discount
        public double CalculateTax()
        {
            return Price * taxRate;
        }

        public override double CalculateDiscount()
        {
            return Price * discountRate;
        }
        public string GetTaxDetails()
        {
            return $"Tax on clothing items is: {taxRate}%.";
        }
    }
    // Concrete Groceries class that extends Product class
    public class Groceries : Product
    {
        public Groceries(int productID, string name, double price) : base(productID, name, price)
        {
        }
        private double discountRate = 0.06; // 6% discount
        public override double CalculateDiscount()
        {
            return Price * discountRate;
        }
    }
    // ITaxable interface
    interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }
}
