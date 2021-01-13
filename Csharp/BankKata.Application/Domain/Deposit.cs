using System;

namespace BankKata
{
    internal class Deposit : Transaction
    {
        private Amount amount;
        private DateTime dateTime;

        public Deposit(double amount, DateTime dateTime)
        {
            this.amount = Amount.Of(amount);
            this.dateTime = dateTime;
        }

        public void Print(IPrinter printer, Amount balance)
        {
            amount.PrintLine(printer, dateTime, balance);
        }

        public Amount UpdateBalance(Amount balance)
        {
            return balance.Add(amount);
        }
    }
}