using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Inheritance
{
    /*
     3. Vehicle and Transport System
Description:
Design a vehicle hierarchy where Vehicle is the superclass, and Car, Truck, and Motorcycle
are subclasses with unique attributes.
Tasks:
1. Define a superclass Vehicle:
o Add two attributes: MaxSpeed (integer) and FuelType (string).
o Add a method DisplayInfo() to display the vehicle's
information.
2. Define subclasses Car, Truck, and Motorcycle that inherit from
Vehicle:
o Car: Add an additional attribute SeatCapacity (integer).
o Truck: Add an additional attribute PayloadCapacity (integer).
o Motorcycle: Add an additional attribute HasSidecar (boolean).
3. Demonstrate polymorphism:
o Store objects of type Car, Truck, and Motorcycle in an array of
Vehicle type.
o Call the DisplayInfo() method on each object in the array and
observe dynamic method dispatch.
Goal: Understand how inheritance helps in organizing shared and unique features across
subclasses and use polymorphism for dynamic method calls.
     */
    // Superclass(Vehicle)
    public class Vehicle
    {
        public int MaxSpeed;
        public string FuelType;

        public Vehicle(int maxSpeed, string fuelType) 
        {
            MaxSpeed = maxSpeed;
            FuelType = fuelType;
        }
        // virtual method that can be overridden in derived classes
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Maximum speed of vehicle: {MaxSpeed} and Fuel Type used: {FuelType}");
        }
    }
    // Subclass(Car)
    public class Car : Vehicle
    {
        public int SeatCapacity;
        public Car(int maxSpeed, string fuelType, int capacity): base(maxSpeed, fuelType) 
        {
                SeatCapacity = capacity;
        }
        // overriding the DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Capacity of person can sit in car: " + SeatCapacity);
        }

    }
    // Subclass(Truck)
    public class Truck : Vehicle
    {
        public int PayloadCapacity;
        public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType)
        {
            this.PayloadCapacity = payloadCapacity;
        }
        // overriding the DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Capacity of person can sit in car: " + PayloadCapacity);
        }
    }
    // Subclass(Motorcycle)
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar;
        public Motorcycle(int maxSpeed, string fuelType, bool HasSidecar) : base(maxSpeed, fuelType)
        {
            this.HasSidecar = HasSidecar;
        }
        // overriding the DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("HasSidecar " + HasSidecar);
        }
    }
}
