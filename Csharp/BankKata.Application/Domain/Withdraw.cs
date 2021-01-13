using System;

namespace BankKata
{
    internal class Withdraw : Transaction
    {
        private Amount amount;
        private DateTime dateTime;

        public Withdraw(double amount, DateTime dateTime)
        {
            this.amount = Amount.NegativeOf(amount);
            this.dateTime = dateTime;
        }

        public void Print(IPrinter printer, Amount balance)
        {
            printer.AddLine(dateTime, amount, balance);
        }

        public Amount UpdateBalance(Amount balance)
        {
            return balance.Add(amount);
        }
    }
}