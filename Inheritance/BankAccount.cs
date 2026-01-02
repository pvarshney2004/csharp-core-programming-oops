using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Inheritance
{
    /*
     Sample Problem 1: Bank Account Types
○ Description: Model a banking system with different account types using
hierarchical inheritance. BankAccount is the superclass, with
SavingsAccount, CheckingAccount, and FixedDepositAccount as
subclasses.
○ Tasks:
■ Define a base class BankAccount with attributes like AccountNumber
and Balance.
■ Define subclasses SavingsAccount, CheckingAccount, and
FixedDepositAccount, each with unique attributes like
interestRate for SavingsAccount and WithdrawalLimit for
CheckingAccount.
■ Implement a method DisplayAccountType() in each subclass to
specify the account type.
○ Goal: Explore hierarchical inheritance, demonstrating how each subclass can
have unique attributes while inheriting from a shared superclass.
     */
    // Base class
    public class BankAccount
    {
        public int AccountNumber;
        public double Balance;

        public BankAccount(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        // virtual method to be overridden in subclasses
        public virtual void DisplayAccountType()
        {
            Console.WriteLine("Normal Bank Account");
        }
    }
    // Derived classes
    public class SavingsAccount: BankAccount
    {
        public double InterestRate;

        public SavingsAccount(int accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }
        // Override method to specify account type
        public override void DisplayAccountType()
        {
            Console.WriteLine("Savings Account");
        }
    }

    public class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit;

        public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
            : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }
        // Override method to specify account type
        public override void DisplayAccountType()
        {
            Console.WriteLine("Checking Account");
        }
    }

    public class FixedDepositAccount: BankAccount
    {
        public int TimeInMonths;
        public FixedDepositAccount(int accountNumber, double balance, int timeInMonths)
            : base(accountNumber, balance)
        {
            TimeInMonths = timeInMonths;
        }
        // Override method to specify account type
        public override void DisplayAccountType()
        {
            Console.WriteLine("Fixed Deposit Account");
        }
    }

}
