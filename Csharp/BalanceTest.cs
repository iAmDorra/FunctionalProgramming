using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankKata
{
    [TestClass]
    public class BalanceTest
    {
        [TestMethod]
        public void Should_return_two_statements_when_deposit_and_a_withdraw()
        {
            Balance balance = new Balance();
            DateTime depositeDate = new DateTime(2021, 01, 08);
            double depositAmount = 200;
            balance.Deposit(depositAmount, depositeDate);
            DateTime withdrawDate = new DateTime(2021, 01, 09);
            double withdrawAmount = 50;
            balance.Withdraw(withdrawAmount, withdrawDate);
            List<Statement> statements = balance.Print();
            Check.That(statements.Count()).IsEqualTo(2);

            Check.That(statements[0].Date).IsEqualTo(depositeDate);
            Check.That(statements[0].Amount).IsEqualTo(depositAmount);
            Check.That(statements[0].Balance).IsEqualTo(depositAmount);

            Check.That(statements[1].Date).IsEqualTo(withdrawDate);
            Check.That(statements[1].Amount).IsEqualTo(-withdrawAmount);
            Check.That(statements[1].Balance).IsEqualTo(depositAmount - withdrawAmount);
        }

        [TestMethod]
        public void Should_return_no_statement_when_balance_is_empty()
        {
            Balance balance = new Balance();
            List<Statement> statements = balance.Print();
            Check.That(statements.Count()).IsEqualTo(0);
        }

        [TestMethod]
        public void Should_return_one_statement_when_operate_a_deposit()
        {
            Balance balance = new Balance();
            DateTime depositeDate = new DateTime(2021, 01, 08);
            double depositAmount = 200;
            balance.Deposit(depositAmount, depositeDate);
            List<Statement> statements = balance.Print();

            Check.That(statements.Count()).IsEqualTo(1);
            Check.That(statements[0].Date).IsEqualTo(depositeDate);
            Check.That(statements[0].Amount).IsEqualTo(depositAmount);
            Check.That(statements[0].Balance).IsEqualTo(depositAmount);
        }

        [TestMethod]
        public void Should_return_one_statement_when_operate_a_withdraw()
        {
            Balance balance = new Balance();
            DateTime withdrawDate = new DateTime(2021, 01, 08);
            double withdrawAmount = 200;
            balance.Withdraw(withdrawAmount, withdrawDate);
            List<Statement> statements = balance.Print();

            Check.That(statements.Count()).IsEqualTo(1);
            Check.That(statements[0].Date).IsEqualTo(withdrawDate);
            Check.That(statements[0].Amount).IsEqualTo(-withdrawAmount);
            Check.That(statements[0].Balance).IsEqualTo(-withdrawAmount);
        }
    }
}
