using System;

namespace BankKata
{
    internal class Statement
    {
        private Transaction deposit;
        private double balance;

        public Statement(Transaction deposit, double balance)
        {
            this.deposit = deposit;
            this.balance = balance;
        }

        internal void Print(IPrinter printer)
        {
            deposit.Print(printer, balance);
        }
    }
}