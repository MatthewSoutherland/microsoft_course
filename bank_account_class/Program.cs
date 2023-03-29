using System;

namespace testing_one
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Matt", 5000.00m);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with a balance of {account.Balance}");

            account.MakeWithDrawal(120, DateTime.Now, "Hammock");

            account.MakeDeposit(150, DateTime.Now, "Deposit");

            account.MakeWithDrawal(200, DateTime.Now, "Prostitute");

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}