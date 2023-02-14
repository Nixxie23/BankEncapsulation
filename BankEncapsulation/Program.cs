namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();
            myAccount.Deposit(300.57);
            Console.WriteLine($"You have a balance of ${myAccount.GetBalance()}");
            myAccount.Deposit();
            Console.WriteLine($"You have a balance of ${myAccount.GetBalance()}");

        }
    }
}
