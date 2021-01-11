﻿using System;

namespace BankKata
{
    internal class Account
    {
        private double balance;
        private Statements statements;

        public Account(double initialBalance)
        {
            this.balance = initialBalance;
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
        }

        internal void PrintStatements(IPrinter printer)
        {
            statements.Print(printer);
        }
    }
}