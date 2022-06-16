using System;
namespace InterfaceDemo
{
    public interface IBankAccount
    {
        public long AccountNumber { get; set; }
        public double CurrentBalance { get; set; }
        public double SSN { get; set; }

        public void Deposit(double amount);//stubbed out method

        public void Withdraw(double amount);


    }
}
