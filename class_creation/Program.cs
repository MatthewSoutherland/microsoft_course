using System;

namespace testing_one
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Matt", 5000.00m);
            Console.WriteLine($"Account {account.number} was created for {account.owner} with a balance of {account.balance}");
        }
    }
}