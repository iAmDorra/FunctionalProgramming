﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;

namespace BankKata
{
    [TestClass]
    public class StatementTest
    {
        [TestMethod]
        public void Should_not_print_when_no_statement_added()
        {
            var statements = new Statements();
            
            IPrinter printer = Substitute.For<IPrinter>();
            statements.Print(printer);

            printer.Received(0);
        }

        [TestMethod]
        public void Should_add_one_line_in_printer_when_print_only_one_statement()
        {
            var statements = new Statements();
            double amount = 1;
            DateTime dateTime = new DateTime(2021, 01, 08);
            Transaction deposit = new Deposit(amount, dateTime);
            double balance = 0;
            statements.Add(deposit, balance);

            IPrinter printer = Substitute.For<IPrinter>();
            statements.Print(printer);

            printer.Received(1).AddLine();
        }
    }
}
