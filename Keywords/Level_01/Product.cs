using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Keywords.Level_01
{
    internal class Product
    {
        /*
Sample Program 4: Shopping Cart System
Create a Product class to manage shopping cart items with the following features:
● static:
o A static variable Discount shared by all products.
o A static method UpdateDiscount() to modify the discount percentage.
● this:
o Use this to initialize ProductName, Price, and Quantity in the constructor.
● readonly:
o Use a readonly variable ProductID to ensure each product has a unique
identifier that cannot be changed.
● is operator:
o Validate whether an object is an instance of the Product class before
processing its details
         */
        // ----------static---------- 
        public static double Discount = 5.0;
        public static void UpdateDiscount(double d)
        {
            Discount = d;
        }

        // ----------instance----------
        public string ProductName;
        public int Price;
        public int Quantity;

        // ----------readonly---------- 
        public readonly int ProductID;

        // constructor
        public Product(string name, int price, int q, int id)
        {
            this.ProductName = name;
            this.Price = price;
            this.Quantity = q;
            this.ProductID = id;
        }

        // method to display product details
        public void DisplayDetails()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Product ID: " + ProductID);
        }
    }
}
