using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using NSubstitute;
using System;

namespace BankKata
{
    [TestClass]
    public class BalanceTest
    {
        [TestMethod]
        public void Should_return_two_statements_when_add_one_deposit_and_one_withdraw()
        {
            const int initialBalance = 0;
            Account account = new Account(initialBalance);
            const double depositAmount = 200.0;
            DateTime depositDate = new DateTime(2021, 01, 08);
            account.Deposit(depositAmount, depositDate);

            const double withdrawAmount = 50.0;
            DateTime withdrawDate = new DateTime(2021, 01, 09);
            account.Withdraw(withdrawAmount, withdrawDate);

            IPrinter printer = new Printer();
            account.PrintStatements(printer);
            var printedBalance = printer.Print();
            string expectedBalance = "|Date|Amount|Balance|" +
                "\n" + "|08/01/2020|200|200|" +
                "\n" + "|09/01/2020|-50|150|";
            Check.That(printedBalance).IsEqualTo(expectedBalance);
        }

        [TestMethod]
        public void Should_return_no_statement_when_print_account_without_any_operation()
        {
            const int initialBalance = 0;
            Account account = new Account(initialBalance);

            IPrinter printer = Substitute.For<IPrinter>();
            account.PrintStatements(printer);
            printer.Received(0).AddLine(Arg.Any<DateTime>(), Arg.Any<double>(), Arg.Any<double>());
        }

        [TestMethod]
        public void Should_return_one_statement_when_print_account_with_one_deposit()
        {
            const int initialBalance = 0;
            Account account = new Account(initialBalance);

            const double depositAmount = 200.0;
            DateTime depositDate = new DateTime(2021, 01, 08);
            account.Deposit(depositAmount, depositDate);

            IPrinter printer = Substitute.For<IPrinter>();
            account.PrintStatements(printer);
            printer.Received(1).AddLine(Arg.Any<DateTime>(), Arg.Any<double>(), Arg.Any<double>());
        }

        [TestMethod]
        public void Should_return_one_statement_when_print_account_with_one_withdraw()
        {
            const int initialBalance = 0;
            Account account = new Account(initialBalance);

            const double withdrawAmount = 200.0;
            DateTime withdrawDate = new DateTime(2021, 01, 08);
            account.Withdraw(withdrawAmount, withdrawDate);

            IPrinter printer = Substitute.For<IPrinter>();
            account.PrintStatements(printer);
            printer.Received(1).AddLine(Arg.Any<DateTime>(), Arg.Any<double>(), Arg.Any<double>());
        }
    }
}
