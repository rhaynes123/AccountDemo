using System;
namespace CustomerAccountDemo
{
    public class Accounts
    {
        public string Number { get; }
        public string AccountHolder { get; set; }
        public string AccountBalance { get;  }

        public void DepositToAccount(decimal amount, DateTime date, string note)
        {
        }

        public void WithdrawFromAccount(decimal amount, DateTime date, string note)
        {
        }
    }
}
