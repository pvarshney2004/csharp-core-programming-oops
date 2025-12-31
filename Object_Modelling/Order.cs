using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Object_Modelling
{
    /*
Problem 4: E-commerce Platform with Orders, Customers, and Products
Description: Design an e-commerce platform with Order, Customer, and Product classes.
Model relationships where a Customer places an Order, and each Order contains multiple
Product objects.
Goal: Show communication and object relationships by designing a system where customers
communicate through orders, and orders aggregate products.
     */
    // Order class
    public class Order
    {
        public int OrderID;
        public List<Product> Products;
        public Order(int orderId)
        {
            OrderID = orderId;
            Products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        // method to calculate total price of the order
        public double CalculateTotal()
        {
            double total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
            }
            return total;
        }
    }
    // Product class
    public class Product
    {
        public string Name;
        public double Price;
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
    // Customer class
    public class Customerr
    {
        public string Name;
        public List<Order> Orders;

        public Customerr(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        // Communication method
        public void PlaceOrder(Order order)
        {
            Orders.Add(order);
            Console.WriteLine($"{Name} placed Order ID: {order.OrderID}");
        }
    }
}
