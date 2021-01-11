using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

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
    }
}
