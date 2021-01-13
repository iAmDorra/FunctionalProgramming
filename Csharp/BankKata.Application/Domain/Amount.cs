using System;

namespace BankKata
{
    public class Amount
    {
        private readonly double value;

        private Amount(double value)
        {
            this.value = value;
        }

        internal static Amount Of(double amount)
        {
            return new Amount(amount);
        }

        internal static Amount NegativeOf(double amount)
        {
            return new Amount(-amount);
        }

        internal void PrintLine(IPrinter printer, DateTime dateTime, Amount balance)
        {
            printer.AddLine(dateTime, value, balance.value);
        }

        internal Amount Add(Amount amount)
        {
            return Amount.Of(this.value + amount.value);
        }

        public override bool Equals(object obj)
        {
            return obj is Amount amount && value == amount.value;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}