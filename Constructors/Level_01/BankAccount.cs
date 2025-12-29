using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Programming_OOPs.Constructors.Level_01
{
    public class BankAccount
    {
        /*
Problem: Bank Account Management
● Create a BankAccount class with:
o accountNumber (public)
o accountHolder (protected)
o balance (private)
● Implement methods to:
o Access and modify balance using public methods.
o Create a subclass SavingsAccount to demonstrate access to accountNumber
and accountHolder.
         */
        public string AccountNumber;
        protected string AccountHolder;
        private double Balance;
        // Constructor
        public BankAccount(string accountNumber, string accountHolder, double initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }
        // Public method to get balance
        public double GetBalance()
        {
            return Balance;
        }
        // public method to set balance
        public void SetBalance(double amount)
        {
            if (amount >= 0)
            {
                Balance = amount;
            }
            else
            {
                Console.WriteLine("Balance cannot be negative.");
            }
        }
    }

    public class SavingsAccount : BankAccount
    {
        public double InterestRate;
        // Constructor using base keyword to call parent constructor
        public SavingsAccount(string accountNumber, string accountHolder, double initialBalance, double interestRate)
            : base(accountNumber, accountHolder, initialBalance)
        {
            InterestRate = interestRate;
        }
        // Method to display account details
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number: " + AccountNumber);                // public
            Console.WriteLine("Account Holder Name: " + AccountHolder);           // protected
            Console.WriteLine("Initial Balance: " + GetBalance());                // private via public method
            Console.WriteLine("Interest Rate " + InterestRate);
        }
    }

}
