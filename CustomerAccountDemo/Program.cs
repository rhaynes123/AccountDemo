using System;

namespace CustomerAccountDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Accounts("Richard", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.AccountHolder} with {account.AccountBalance} initial balance."); ;
        }
    }
}
