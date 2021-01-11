using System;

namespace BankKata
{
    internal class Deposit : Transaction
    {
        private double amount;
        private DateTime dateTime;

        public Deposit(double amount, DateTime dateTime)
        {
            this.amount = amount;
            this.dateTime = dateTime;
        }

        public void Print(IPrinter printer, double balance)
        {
            printer.AddLine(dateTime, amount, balance);
        }

        public double UpdateBalance(double balance)
        {
            return amount + balance;
        }
    }
}