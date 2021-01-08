using System;

namespace BankKata
{
    internal class Statement
    {
        public Statement(DateTime dateTime, double v1, double v2)
        {
            Date = dateTime;
            Amount = v1;
            Balance = v2;
        }

        public DateTime Date { get; internal set; }
        public double Amount { get; internal set; }
        public double Balance { get; internal set; }
    }
}