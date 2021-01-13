namespace BankKata
{
    internal interface ITransaction
    {
        Amount UpdateBalance(Amount balance);
        void Print(IPrinter printer, Amount balance);
    }
}