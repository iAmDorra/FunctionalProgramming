using System;

namespace BankKata
{
    internal class Withdraw : ITransaction
    {
        private readonly Amount amount;
        private readonly DateTime dateTime;

        public Withdraw(double amount, DateTime dateTime)
        {
            this.amount = Amount.NegativeOf(amount);
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