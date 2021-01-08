using System;
using System.Collections.Generic;

namespace BankKata
{
    internal class Balance
    {
        private readonly List<Operation> operations = new List<Operation>();

        internal List<Statement> Print()
        {
            List<Statement> statements = new List<Statement>();
            double balance = 0;
            foreach (var operation in operations)
            {
                Statement statement = operation.CreateStatement(balance);
                balance = statement.Balance;
                statements.Add(statement);
            }
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