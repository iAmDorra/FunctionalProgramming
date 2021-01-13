using System;

namespace BankKata
{
    internal class Statement
    {
        private Transaction transaction;
        private Amount balance;

        public Statement(Transaction transaction, Amount balance)
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