namespace BankKata
{
    public interface IPrinter
    {
        void AddLine(System.DateTime dateTime, double amount, double balance);
        string Print();
    }
}