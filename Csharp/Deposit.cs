using System;

namespace BankKata
{
    internal class Deposit : Transaction
    {
        private double amount;
        private DateTime dateTime;

        public Deposit(double v, DateTime dateTime)
        {
            this.amount = v;
            this.dateTime = dateTime;
        }

        public double UpdateBalance(double balance)
        {
            return amount + balance;
        }
    }
}