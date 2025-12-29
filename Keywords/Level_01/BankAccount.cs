using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Keywords.Level_01
{
    internal class BankAccount
    {
        /*
Sample Program 1: Bank Account System
Create a BankAccount class with the following features:
● static:
o A static variable bankName shared across all accounts.
o A static method GetTotalAccounts() to display the total number of accounts.
● this:
o Use this to resolve ambiguity in the constructor when initializing
AccountHolderName and AccountNumber.
● readonly:
o Use a readonly variable AccountNumber to ensure it cannot be changed once
assigned.
● is operator:
o Check if an account object is an instance of the BankAccount class before
displaying its details.
         */

        // --------static---------
        public static string BankName = "National Bank of India(NBI)";
        private static int totalAccounts = 0;
        public static void GetTotalAccounts()
        {
            Console.WriteLine("Total Accounts: " + totalAccounts);
        }

        // --------readonly---------
        public readonly int AccountNumber;

        // --------instance variables---------
        public string AccountHolderName;

        // constructor
        public BankAccount(int accountNumber, string accountHolderName)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            totalAccounts++;
        }

        // method to display account details
        public void DisplayDetails()
        {
            Console.WriteLine("Bank Name: " + BankName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Holder: " + AccountHolderName);
        }


    }
}
