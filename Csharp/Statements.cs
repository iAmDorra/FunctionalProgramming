using System.Collections.Generic;
using System.Linq;

namespace BankKata
{
    internal class Statements
    {
        private List<Statement> statements = new List<Statement>();

        internal void Print(IPrinter printer)
        {
            if(statements.Any())
            {
                printer.AddLine();
            }
        }

        internal void Add(Transaction transaction, double balance)
        {
            statements.Add(new Statement());
        }
    }
}