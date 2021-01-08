using System;

namespace BankKata
{
    internal class Withdraw : Operation
    {
        public Withdraw(double amount, DateTime dateTime)
        {
            Amount = amount;
            Date = dateTime;
        }

        internal static Operation Of(double amount, DateTime dateTime)
        {
            return new Withdraw(-amount, dateTime);
        }
    }
}