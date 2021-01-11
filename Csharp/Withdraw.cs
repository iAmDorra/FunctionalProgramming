using System;

namespace BankKata
{
    internal class Withdraw : Operation
    {
        private Withdraw(double amount, DateTime dateTime)
        {
            Amount = amount;
            Date = dateTime;
        }

        public double Amount { get; private set; }
        public DateTime Date { get; private set; }

        internal static Operation Of(double amount, DateTime dateTime)
        {
            return new Withdraw(-amount, dateTime);
        }
    }
}