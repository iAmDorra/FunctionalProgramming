namespace BankKata
{
    public interface IPrinter
    {
        void AddLine(System.DateTime dateTime, Amount amount, Amount balance);
        string Print();
    }
}