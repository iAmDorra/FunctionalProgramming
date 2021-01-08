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
            balance.Deposit(200, new DateTime(2021, 01, 08));
            balance.Withdraw(50, new DateTime(2021, 01, 09));
            List<Statement> statements = balance.Print();
            Check.That(statements.Count()).IsEqualTo(2);
        }

        [TestMethod]
        public void Should_return_no_statement_when_balance_is_empty()
        {
            Balance balance = new Balance();
            List<Statement> statements = balance.Print();
            Check.That(statements.Count()).IsEqualTo(0);
        }
    }
}
