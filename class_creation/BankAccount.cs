using System;

namespace testing_one
{
    public class BankAccount
    {
        public string number { get; }
        public string owner { get; set; }
        public decimal balance { get; }
        public BankAccount(string name, decimal initialBalance)
        {
            this.owner = name;
            this.balance = initialBalance;
        }
        public void makeDeposit(decimal amount, DateTime date, string note)
        {

        }
        public void makeWithDrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}