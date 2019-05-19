using System;
using System.Text;
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

        public string ShowAccountHistory()
        {
            var TransactionReport = new StringBuilder();
            TransactionReport.AppendLine("Date\tAmount\tNote");

            foreach (var newtransaction in allTransactions)
            {
                TransactionReport.AppendLine($"{newtransaction.TransDate.ToShortDateString()}\t${newtransaction.TransAmount}\t{newtransaction.TransNotes}");
            }

            return TransactionReport.ToString();
        }

        public Accounts(string name, decimal originalbalance)
        {
            Number = num.Next(100000, 999999);//Remember this doesn't prevent duplicates
            AccountHolder = name;
            DepositToAccount(originalbalance, DateTime.Now, "Original Balance");
           
        }
    }
}
