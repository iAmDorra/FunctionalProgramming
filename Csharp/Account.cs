using System;
using System.Collections.Generic;

namespace BankKata
{
    internal class Account
    {
        private double balance;

        public Account(double initialBalance)
        {
            this.balance = initialBalance;
        }

        internal void Deposit(double v, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        internal void Withdraw(double v, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        internal List<Statement> PrintStatements()
        {
            throw new NotImplementedException();
        }
    }
}