using System;

namespace BankKata
{
    internal class Statement
    {
        private readonly ITransaction transaction;
        private readonly Amount balance;

        public Statement(ITransaction transaction, Amount balance)
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