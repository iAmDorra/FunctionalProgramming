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
            List<Statement> statements = account.PrintStatements();
            Check.That(statements.Count()).IsEqualTo(2);

            Check.That(statements[0].Date).IsEqualTo(depositDate);
            Check.That(statements[0].Amount).IsEqualTo(depositAmount);
            Check.That(statements[0].Balance).IsEqualTo(depositAmount);

            Check.That(statements[1].Date).IsEqualTo(withdrawDate);
            Check.That(statements[1].Amount).IsEqualTo(withdrawAmount);
            Check.That(statements[1].Balance).IsEqualTo(depositAmount - withdrawAmount);
        }

        [TestMethod]
        public void Should_return_no_statement_when_print_account_without_any_operation()
        {
            const int initialBalance = 0;
            Account account = new Account(initialBalance);

            List<Statement> statements = account.PrintStatements();
            Check.That(statements.Count()).IsEqualTo(0);
        }
    }
}
