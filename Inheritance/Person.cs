using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Inheritance
{
    /*
     Sample Problem 1: Restaurant Management System with Hybrid
Inheritance
○ Description: Model a restaurant system where Person is the superclass and
Chef and Waiter are subclasses. Both Chef and Waiter should implement a
Worker interface that requires a PerformDuties() method.
○ Tasks:
■ Define a superclass Person with attributes like Name and Id.
■ Create an interface Worker with a method PerformDuties().
■ Define subclasses Chef and Waiter that inherit from Person and
implement the Worker interface, each providing a unique implementation
of PerformDuties().
○ Goal: Practice hybrid inheritance by combining inheritance and interfaces, giving
multiple behaviors to the same objects.
     */
    // Superclass
    public class Person
    {
        public int Id;
        public string Name;
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    // Worker Interface
    interface IWorker
    {
        // abstract method
        void PerformDuties();
    }
    // Subclass Chef implementing IWorker and inheriting from Person
    public class Chef : Person, IWorker
    {
        public Chef(int id, string name) : base(id, name)
        {
        }
        // Implementing PerformDuties method
        public void PerformDuties()
        {
            Console.WriteLine("Chef performing cooking duties.");
        }
    }
    // Subclass Waiter implementing IWorker and inheriting from Person
    public class Waiter :Person, IWorker
    {
        public Waiter(int id, string name) : base(id, name)
        {
        }
        // Implementing PerformDuties method
        public void PerformDuties()
        {
            Console.WriteLine("Waiter serving customers.");
        }
    }
}
