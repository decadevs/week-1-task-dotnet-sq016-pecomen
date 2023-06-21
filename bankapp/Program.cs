using System;
using static bankapp.Client;

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
            Console.WriteLine("Enter 4 to Print Account statement ");

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
                case "4":
                    PrintAccounts();
                    break;
                default:
                    break;
            }
        }


            //var account = new SavingsAccount(user, 10000, data);
            //Console.WriteLine($"Account {account} was created for {account.Owner.FirstName} with {account.Balance}");

            //account.MakeWithdrawal(100,DateTime.Now,"Food");

            //Console.WriteLine(account.Balance);
            //Console.ReadKey();

            // Method to print all accounts in the bank
        public class BankAccountTransactions
        {
            public string FullName { get; set; }
            public int AccountNumber { get; set; }
            public string AccountType { get; set; }
            public int Balance { get; set; }
            public string Note { get; set; }
            public BankAccountTransactions(string fullName, int accountNumber, string accountType, int balance, string note)
            {
                FullName = fullName;
                AccountNumber = accountNumber;
                AccountType = accountType;
                Balance = balance; Note = note;
            }


        }
        public static void PrintAccounts()

        {

            Console.WriteLine("write your fullName");

            string? fullName = Console.ReadLine();
            Console.WriteLine("write your Account Number");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("write your Account Type");
            string? accountType = Console.ReadLine();
            Console.WriteLine(" Acount Balance?");
            int balance = int.Parse(Console.ReadLine());
            Console.WriteLine("write a note"); string? note = Console.ReadLine();

            BankAccountTransactions banktrans = new(fullName, accountNumber, accountType, balance, note);
            Console.WriteLine("|---------------|------------------|--------------|-------------|--------|");
            Console.WriteLine("| FULL NAME | ACCOUNT NUMBER | ACCOUNT TYPE | ACCOUNT BAL | NOTE |");
            Console.WriteLine("|---------------|------------------|--------------|-------------|--------|");
            Console.WriteLine($"| {banktrans.FullName,-12} | {banktrans.AccountNumber,-15} | {banktrans.AccountType,-15} | {banktrans.Balance,-14} | {banktrans.Note,-10} |");
            Console.WriteLine("|---------------|------------------|--------------|-------------|--------|");
        }

        
}   }

