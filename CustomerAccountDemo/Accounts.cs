using System;
using System.Collections.Generic;

namespace CustomerAccountDemo
{
    public class Accounts
    {
        private List<Transaction> allTransactions = new List<Transaction>();

        readonly Random num = new Random();

        public int Number { get; }
        public string AccountHolder { get; set; }

        public decimal AccountBalance
        {
            get 
            {
                decimal balance = 0;

                foreach(var newtransaction in allTransactions)
                {
                    balance += newtransaction.TransAmount;
                }

                return balance;
            }
              
        }

        public void DepositToAccount(decimal amount, DateTime date, string note)
        {
            if(amount <=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Amount of deposit must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void WithdrawFromAccount(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawl must be positive");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public Accounts(string name, decimal currentbalance)
        {
            Number = num.Next(100000, 999999);//Remember this doesn't prevent duplicates
            AccountHolder = name;
            DepositToAccount(currentbalance, DateTime.Now, "Current Balance");
           
        }
    }
}
