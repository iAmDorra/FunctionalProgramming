using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BankKata.Tests")]
namespace BankKata
{
    internal class Account
    {
        private Amount balance;
        private Statements statements;

        public Account(double initialBalance)
        {
            this.balance = new Amount(initialBalance);
            statements = new Statements();
        }

        internal void Deposit(double v, DateTime dateTime)
        {
            Transaction deposit = new Deposit(v, dateTime);
            balance = deposit.UpdateBalance(balance);
            statements.Add(deposit, balance);
        }

        internal void Withdraw(double v, DateTime dateTime)
        {
            Transaction withdraw = new Withdraw(v, dateTime);
            balance = withdraw.UpdateBalance(balance);
            statements.Add(withdraw, balance);
        }

        internal void PrintStatements(IPrinter printer)
        {
            statements.Print(printer);
        }
    }
}