using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Constructors.Level_01
{
    internal class Product
    {
        /*
Problem : Product Inventory
● Create a Product class with:
o Instance Variables: productName, price.
o Class Variable: totalProducts (shared among all products).
● Implement the following methods:
o An instance method DisplayProductDetails() to display the details of a
product.
o A class method DisplayTotalProducts() to show the total number of
products created.
         */
        public string ProductName;
        public double Price;
        public static int TotalProducts = 0;
        // parameterized Constructor
        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
            TotalProducts++;
        }
        // instance method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}, Price: {Price}");
        }
        // class method to display total products
        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products: {TotalProducts}");
        }

    }
}
