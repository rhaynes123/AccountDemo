using System;

namespace CustomerAccountDemo
{
    public class Accounts
    {
        readonly Random num = new Random();

        public int Number { get; }
        public string AccountHolder { get; set; }
        public decimal AccountBalance { get;  }

        public void DepositToAccount(decimal amount, DateTime date, string note)
        {
        }

        public void WithdrawFromAccount(decimal amount, DateTime date, string note)
        {
        }

        public Accounts(string name, decimal currentbalance)
        {
            Number = num.Next(100000, 999999);//Remeber this doesn't prevent duplicates
            AccountHolder = name;
            AccountBalance = currentbalance;
        }
    }
}
