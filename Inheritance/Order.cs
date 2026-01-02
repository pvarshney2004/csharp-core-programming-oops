using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Inheritance
{
    /*
     Sample Problem 1: Online Retail Order Management
○ Description: Create a multilevel hierarchy to manage orders, where Order is
the base class, ShippedOrder is a subclass, and DeliveredOrder extends
ShippedOrder.
○ Tasks:
■ Define a base class Order with common attributes like orderId and
OrderDate.
■ Create a subclass ShippedOrder with additional attributes like
TrackingNumber.
■ Create another subclass DeliveredOrder extending ShippedOrder,
adding a DeliveryDate attribute.
■ Implement a method GetOrderStatus() to return the current order
status based on the class level.
○ Goal: Explore multilevel inheritance, showing how attributes and methods can be
added across a chain of classes.
     */
    // Base class(order)
    public class Order
    {
        public int OrderID;
        public DateTime OrderDate;
        public Order(int orderID, DateTime orderDate)
        {
            OrderID = orderID;
            OrderDate = orderDate;
        }
        // virtual method that can be overridden in derived classes
        public virtual string GetOrderStatus()
        {
            return $"Order Placed on {OrderDate}";
        }
    }
    // Derived class (shipped order)
    public class ShippedOrder : Order
    {
        public string TrackingNumber;
        public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
            : base(orderId, orderDate)
        {
            this.TrackingNumber = trackingNumber;
        }
        // overriding the base class method
        public override string GetOrderStatus()
        {
            return "Order Shipped";
        }
    }

    // Further derived class (delivered order)
    public class DeliveredOrder : ShippedOrder
    {
        public DateTime DeliveryDate;

        public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
            : base(orderId, orderDate, trackingNumber)
        {
            DeliveryDate = deliveryDate;
        }
        // overriding the base class method
        public override string GetOrderStatus()
        {
            return $"Order Delivered on date: {DeliveryDate}";
        }
    }
}
