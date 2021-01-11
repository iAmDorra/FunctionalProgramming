using System;

namespace BankKata
{
    internal interface Operation
    {
        double Amount { get; }
        DateTime Date { get; }

        public Statement CreateStatement(double balance)
        {
            return new Statement(Date, Amount, Amount + balance);
        }
    }
}