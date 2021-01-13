using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using NSubstitute;
using System;

namespace BankKata
{
    [TestClass]
    public class WithdrawTest
    {
        [TestMethod]
        public void Should_update_balance_when_create_a_withdraw()
        {
            var balance = 2.1;
            double amount = 1;
            DateTime dateTime = new DateTime(2021, 01, 08);
            Transaction withdraw = new Withdraw(amount, dateTime);
            var newBalance = withdraw.UpdateBalance(new Amount(balance));
            Check.That(newBalance).IsEqualTo(new Amount(1.1));
        }

        [TestMethod]
        public void Should_print_withdraw_with_right_info()
        {
            var balance = new Amount(2.1);
            double amount = 1;
            DateTime dateTime = new DateTime(2021, 01, 08);
            Transaction withdraw = new Withdraw(amount, dateTime);

            IPrinter printer = Substitute.For<IPrinter>();
            withdraw.Print(printer, balance);

            printer.Received(1).AddLine(dateTime, new Amount(-amount), balance);
        }
    }
}
