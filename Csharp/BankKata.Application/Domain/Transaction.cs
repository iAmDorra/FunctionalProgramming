namespace BankKata
{
    internal interface Transaction
    {
        Amount UpdateBalance(Amount balance);
        void Print(IPrinter printer, Amount balance);
    }
}