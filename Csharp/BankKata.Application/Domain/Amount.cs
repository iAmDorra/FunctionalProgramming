using System;

namespace BankKata
{
    public class Amount
    {
        private double value;

        private Amount(double value)
        {
            this.value = value;
        }

        internal Amount Add(double value)
        {
            return Amount.Of(this.value + value);
        }

        internal static Amount Of(double amount)
        {
            return new Amount(amount);
        }

        internal static Amount NegativeOf(double amount)
        {
            return new Amount(-amount);
        }

        internal Amount Add(Amount amount)
        {
            return Amount.Of(this.value + amount.value);
        }

        public override bool Equals(object obj)
        {
            var amount = obj as Amount;
            return amount != null && value == amount.value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}