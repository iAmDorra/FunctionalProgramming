namespace BankKata
{
    internal interface Transaction
    {
        double UpdateBalance(double balance);
        void Print(IPrinter printer, double balance);
    }
}