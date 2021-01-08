using System;

namespace BankKata
{
    internal class Deposit : Operation
    {
        public Deposit(double amount, DateTime dateTime)
        {
            Amount = amount;
            Date = dateTime;
        }

        public static Deposit Of(double amount, DateTime dateTime)
        {
            return new Deposit(amount, dateTime);
        }
    }
}