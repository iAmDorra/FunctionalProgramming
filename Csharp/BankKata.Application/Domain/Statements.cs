using System.Collections.Generic;
using System.Linq;

namespace BankKata
{
    internal class Statements
    {
        private readonly List<Statement> statements = new List<Statement>();

        internal void Print(IPrinter printer)
        {
            statements.ForEach(statement => statement.Print(printer));
        }

        internal void Add(ITransaction transaction, Amount balance)
        {
            statements.Add(new Statement(transaction, balance));
        }
    }
}