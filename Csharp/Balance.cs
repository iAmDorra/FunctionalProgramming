using System;
using System.Collections.Generic;
using System.Linq;

namespace BankKata
{
    internal class Balance
    {
        private readonly List<Operation> operations = new List<Operation>();

        internal List<Statement> Print()
        {
            double balance = 0;
            List<Statement> statements = operations
                .Select(operation =>
                {
                    var statement = operation.CreateStatement(balance);
                    balance = statement.Balance;
                    return statement;
                })
                .ToList();

            return statements;
        }

        internal void Deposit(double v, DateTime dateTime)
        {
            operations.Add(BankKata.Deposit.Of(v, dateTime));
        }

        internal void Withdraw(double v, DateTime dateTime)
        {
            operations.Add(BankKata.Withdraw.Of(v, dateTime));
        }
    }
}