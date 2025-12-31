using System;

namespace Core_Programming_OOPs.Object_Modelling
{
    /*
Problem 2: Bank and Account Holders (Association)
Description: Model a relationship where a Bank has Customer objects associated with it. A
Customer can have multiple bank accounts, and each account is linked to a Bank.
Tasks:
● Define a Bank class and a Customer class.
● Use an association relationship to show that each Customer has an account in a
Bank.
● Implement methods that enable communication, such as OpenAccount() in the Bank
class and ViewBalance() in the Customer class.
Goal: Illustrate association by setting up a relationship between customers and the bank.
     */
    // Bank class
    public class Bank
    {
        public string BankName;

        public Bank(string bankName)
        {
            BankName = bankName;
        }
        // method to open account for customer 
        public void OpenAccount(Customer customer, double initialBalance)
        {
            customer.balance = initialBalance;
            customer.BankName = this;  // Set the bank association
            Console.WriteLine($"Account opened for {customer.Name} at {BankName} with initial balance {initialBalance}");
        }
    }
    // Customer class
    public class Customer
    {
        public string Name;
        public double balance;
        public Bank BankName; // Association with Bank
        public Customer(string name)
        {
            Name = name;
        }
        // method to view balance
        public void ViewBalance()
        {
            Console.WriteLine($"Customer: {Name}, Bank: {BankName.BankName}, Balance: {balance}");
        }
    }
}
