using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.OOPs_Pillars
{
    /*
     6. Online Food Delivery System
Description: Create an online food delivery system:
● Define an abstract class FoodItem with fields like itemName, price, and quantity.
● Add abstract methods CalculateTotalPrice() and concrete methods like
GetItemDetails().
● Extend it into classes VegItem and NonVegItem, overriding CalculateTotalPrice() to
include additional charges.
● Use an interface IDiscountable with methods ApplyDiscount() and GetDiscountDetails().
● Use polymorphism to handle different types of food items dynamically.
     */
    // interface IDiscountable
    interface IDiscountable
    {
        double ApplyDiscount();
        string GetDiscountDetails();
    }
    // abstract class FoodItem
    public abstract class FoodItem
    {
        public string ItemName;
        public double Price;
        public int Quantity;
        public FoodItem(string name, double price, int quantity)
        {
            ItemName = name;
            Price = price;
            Quantity = quantity;
        }

        public abstract double CalculateTotalPrice();
        // displaying item details
        public void GetItemDetails()
        {
            Console.WriteLine("Item Details: ");
            Console.WriteLine($"{ItemName} | Total Price: {CalculateTotalPrice()}");
        }
    }
    // subclass VegItem that inherit FoodItem and  implements IDiscountable
    class VegItem : FoodItem, IDiscountable
    {
        private int deliveryFee = 100;
        public VegItem(string name, double price, int qty) : base(name, price, qty) { }
        public override double CalculateTotalPrice()
        {
            return (Price * Quantity)+deliveryFee;
        }
        public double ApplyDiscount()
        {
            return 50;
        }
        public string GetDiscountDetails()
        {
            return "Veg Discount Applied";
        }
    }
    // subclass VegItem that inherit FoodItem

    class NonVegItem : FoodItem
    {
        private int deliveryFee = 150;
        public NonVegItem(string name, double price, int qty) : base(name, price, qty) { }
        public override double CalculateTotalPrice()
        {
            return (Price * Quantity)+deliveryFee;
        }
    }
}
