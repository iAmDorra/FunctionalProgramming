using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace BankKata.Tests
{
    [TestClass]
    public class PrinterTest
    {
        [TestMethod]
        public void Should_print_one_added_line()
        {
            var printer = new Printer();
            System.DateTime date = new System.DateTime(2020, 01, 08);
            var balance = new Amount(200);
            var amount = new Amount(200);
            printer.AddLine(date, amount, balance);

            var printedLine = printer.Print();

            string expectedLine = "|Date|Amount|Balance|" +
                "\n" + "|08/01/2020|200|200|";
            Check.That(printedLine).IsEqualTo(expectedLine);
        }

        [TestMethod]
        public void Should_print_two_added_lines()
        {
            var printer = new Printer();
            System.DateTime date = new System.DateTime(2020, 01, 08);
            int balanceValue = 200;
            var balance = new Amount(balanceValue);
            var amount = new Amount(200);
            printer.AddLine(date, amount, balance);

            System.DateTime secondDate = new System.DateTime(2020, 01, 09);
            double secondAmount = 100;
            printer.AddLine(secondDate, new Amount(secondAmount), new Amount(balanceValue + secondAmount));

            var printedLine = printer.Print();

            string expectedLine = "|Date|Amount|Balance|" +
                "\n" + "|08/01/2020|200|200|" +
                "\n" + "|09/01/2020|100|300|";
            Check.That(printedLine).IsEqualTo(expectedLine);
        }
    }
}
