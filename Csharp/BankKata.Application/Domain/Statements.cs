using System.Collections.Generic;
using System.Linq;

namespace BankKata
{
    internal class Statements
    {
        private List<Statement> statements = new List<Statement>();

        internal void Print(IPrinter printer)
        {
            statements.ForEach(statement => statement.Print(printer));
        }

        internal void Add(Transaction transaction, Amount balance)
        {
            statements.Add(new Statement(transaction, balance));
        }
    }
}