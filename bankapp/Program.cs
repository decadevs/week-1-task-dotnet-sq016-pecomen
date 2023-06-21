using System;

namespace bankapp
{

    class Program
    {
       static void Main(string[] args)
        {
            Data data = new Data();
            Client client = new Client(data);
            Console.WriteLine("You can Continue to Enjoy our Service By Doing the Following");

            Console.WriteLine("Enter 1 to Create new Account ");
            Console.WriteLine("Enter 2 to Deposit into Existing Account ");
            Console.WriteLine("Enter 3 to Withdraw from Existing Account ");

            var prompt = Console.ReadLine();
            switch (prompt)
            {
                case "1":
                    client.CreateAccount();
                    break;
                case "2":
                    client.MakeDeposit();
                    break;
                case "3":
                    client.MakeWidrawal();
                    break;
                default:
                    break;
            }

            //var account = new SavingsAccount(user, 10000, data);
            //Console.WriteLine($"Account {account} was created for {account.Owner.FirstName} with {account.Balance}");

            //account.MakeWithdrawal(100,DateTime.Now,"Food");
            Console.ReadKey();
            //Console.WriteLine(account.Balance);
        }
    }

}