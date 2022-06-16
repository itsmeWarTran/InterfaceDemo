using System;
namespace InterfaceDemo
{
    public class CheckingAccount : IBankAccount
    {
        public CheckingAccount()
        {

        }

        public long AccountNumber { get; set; }
        public double CurrentBalance { get; set; }
        public double SSN { get ; set; }


        public void Deposit(double amount)
        {
            CurrentBalance += amount;
            Console.WriteLine($"Current Balance: {CurrentBalance}");
        }

        public void Withdraw(double amount)
        {
            CurrentBalance -= amount;
            Console.WriteLine($"Current Balance: {CurrentBalance}");
        }
    }
}
