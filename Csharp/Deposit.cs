using System;

namespace BankKata
{
    internal class Deposit : Operation
    {
        private Deposit(double amount, DateTime dateTime)
        {
            Amount = amount;
            Date = dateTime;
        }

        public double Amount { get; private set; }
        public DateTime Date { get; private set; }

        public static Deposit Of(double amount, DateTime dateTime)
        {
            return new Deposit(amount, dateTime);
        }
    }
}