using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.OOPs_Pillars
{
    /*
     4. Banking System
Description: Create a banking system with different account types:
● Define an abstract class BankAccount with fields like accountNumber, holderName,
and balance.
● Add methods like Deposit(double amount), Withdraw(double amount), and an abstract
method CalculateInterest().
● Implement subclasses SavingsAccount and CurrentAccount with unique interest
calculations.
● Create an interface ILoanable with methods ApplyForLoan() and
CalculateLoanEligibility().
● Use encapsulation to secure account details and restrict unauthorized access.
● Demonstrate polymorphism by processing different account types and calculating
interest dynamically.
     */

    // interface ILoanable
    interface ILoanable
    {
        void ApplyForLoan(double amount);
        bool CalculateLoanEligibility();
    }
    // abstract class BankAccount
    public abstract class BankAccount
    {
        private int accountNumber;
        private string holderName;
        private double balance;

        public BankAccount(int accountNumber, string holderName, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = initialBalance;
        }
        // method to set balance
        public double Balance
        {
            get { return balance; }
            set {
                if (value < 0)
                {
                    throw new Exception("Balance cannot be negative.");
                }
                balance = value;
            }
        }
        // methods for deposit and withdraw
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }

            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        public abstract double CalculateInterest();
        public void DisplayDetails()
        {
            Console.WriteLine("Account Details:");
            Console.WriteLine($"Account No: {accountNumber}");
            Console.WriteLine($"Holder Name: {holderName}");
            Console.WriteLine($"Balance: {balance}");
            Console.WriteLine($"Interest: {CalculateInterest()}");
        }
    }

    // subclass SavingsAccount that implements ILoanable and inherits BankAccount
    public class SavingsAccount : BankAccount, ILoanable
    {
        private double interestRate = 0.04; 
        public SavingsAccount(int accNo, string name, double balance)
            : base(accNo, name, balance) { }

        // override CalculateInterest 
        public override double CalculateInterest()
        {
            return Balance * interestRate;
        }
        public void ApplyForLoan(double amount)
        {
            Console.WriteLine("Loan of "+ amount + " applied for Savings Account");
        }

        public bool CalculateLoanEligibility()
        {
            return Balance >= 100000;
        }
    }

    // subclass CurrentAccount that inherits BankAccount

    public class CurrentAccount : BankAccount
    {
        private double interestRate = 0.01;

        public CurrentAccount(int accNo, string name, double balance)
            : base(accNo, name, balance) { }

        public override double CalculateInterest()
        {
            return Balance * interestRate;
        }
    }
}
