using System;

namespace BankKata
{
    internal class Printer : IPrinter
    {
        private string line = string.Empty;

        public void AddLine(DateTime dateTime, double amount, double balance)
        {
            var date = dateTime.ToString("d");
            line += "\n" + $"|{date}|" +
                $"{amount}|" +
                $"{balance}|";
        }

        public string Print()
        {
            string header = "|Date|Amount|Balance|";
            return header + line;
        }
    }
}