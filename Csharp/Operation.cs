using System;

namespace BankKata
{
    internal class Operation
    {
        public double Amount { get; internal set; }
        public DateTime Date { get; internal set; }

        public Statement CreateStatement(double balance)
        {
            return new Statement(Date, Amount, Amount + balance);
        }
    }
}