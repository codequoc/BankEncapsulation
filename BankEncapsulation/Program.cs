namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var piggie = new BankAccount();
            piggie.Deposit(100);
            piggie.GetBalance();
        }
    }
}
