using System;

namespace BankKata
{
    public class Amount
    {
        private double value;

        public Amount(double value)
        {
            this.value = value;
        }

        internal Amount Add(double value)
        {
            return new Amount(this.value + value);
        }

        internal static Amount NegativeOf(double amount)
        {
            throw new NotImplementedException();
        }

        internal Amount Add(Amount amount)
        {
            return new Amount(this.value + amount.value);
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