using System;

namespace CustomerAccountDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            var account = new Accounts("Richard", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.AccountHolder} with ${account.AccountBalance} initial balance.");

            Console.WriteLine("Are you making a Deposit Or Withdrawl?");
            string selection = Console.ReadLine();

            Console.Write("Please enter amount\n$");
            decimal EnteredAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter note");
            string UsersNote = Console.ReadLine();

            // ---------
            if (selection.ToUpper() == "DEPOSIT")
            {
                account.DepositToAccount(EnteredAmount, DateTime.Now, UsersNote);
            }

            else if (selection.ToUpper() == "WITHDRAWL")
            {
                account.WithdrawFromAccount(EnteredAmount, DateTime.Now, UsersNote);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            // ---------

            Console.WriteLine("$"+account.AccountBalance+"\n"+ account.ShowAccountHistory());
           
        }
    }
}
