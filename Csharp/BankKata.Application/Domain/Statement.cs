using System;

namespace BankKata
{
    internal class Statement
    {
        private Transaction transaction;
        private double balance;

        public Statement(Transaction transaction, double balance)
        {
            this.transaction = transaction;
            this.balance = balance;
        }

        internal void Print(IPrinter printer)
        {
            transaction.Print(printer, balance);
        }
    }
}