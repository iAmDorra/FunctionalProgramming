﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using System;

namespace BankKata
{
    [TestClass]
    public class DepositTest
    {
        [TestMethod]
        public void Should_update_balance_when_create_a_deposit()
        {
            var balance = 2.1;
            double amount = 1;
            DateTime dateTime = new DateTime(2021, 01, 08);
            Transaction deposit = new Deposit(amount, dateTime);
            balance = deposit.UpdateBalance(balance);
            Check.That(balance).IsEqualTo(3.1);
        }
    }
}
