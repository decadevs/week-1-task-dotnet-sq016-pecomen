using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace bankapp
{
    public class Client
    {
        private static readonly Regex regex = new Regex(@"^\d+$");
        public Data _data;
        public Client(Data data) {
            _data = data;   
            Console.WriteLine("======================WELCOME TO MY BANK APP=============================================");  
        } 
        public void CreateAccount() 
        {
            Console.WriteLine(" create new account");
            Console.WriteLine("enter your First Name");
            var firstName = Console.ReadLine();
            Console.WriteLine("enter your Last Name");
            var lastName = Console.ReadLine();
            Console.WriteLine("To create Savings Account,enter 1");
            Console.WriteLine("to create Current Account,enter 2");
            var accountPrompt = Console.ReadLine();
            User user = new User();
            user.FirstName = firstName;
            user.LastName = lastName;
            if (accountPrompt == "1")
            {
               
                foreach (var item in _data.bankAccounts)
                {
                   if( item.Owner.FirstName == firstName)
                    {
                        if (item.Owner.LastName == lastName) 
                        { 
                            if(item.AccountType == "savings")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("enter initial deposit");
                                var amount = Console.ReadLine();
                                BankAccount savings = new SavingsAccount(user, decimal.Parse(amount),_data  );
                                _data.bankAccounts.Add(savings);
                            }
                        }

                    }
                    
                }

                //var account = new SavingsAccount(user, 10000, _data);

            }
            else if (accountPrompt == "2") 
            {
                foreach (var item in _data.bankAccounts)
                {
                    if (item.Owner.FirstName == firstName)
                    {
                        if (item.Owner.LastName == lastName)
                        {
                            if (item.AccountType == "current")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("enter initial deposit");
                                var amount = Console.ReadLine();
                                BankAccount current = new CurrentAccount(user, decimal.Parse(amount), _data);
                                _data.bankAccounts.Add(current);
                            }
                        }

                    }

                }

            }
        }
        
        public void MakeDeposit()
        {
            long AcctNum;
            decimal amt;
            Console.WriteLine("Please Follow the Prompt to Deposit into your Account");
            Console.WriteLine("Enter your Account Number");
            var acctNum = Console.ReadLine();

            AcctNum = ValidateAccountNum(acctNum, _data.bankAccounts);
            
            Console.WriteLine("Enter Amount to Deposit");
            var amount = Console.ReadLine();

            Console.WriteLine("Enter Transaction Description");
            var note = Console.ReadLine();

            amt = ValidateAmount(amount);
            foreach (var item in _data.bankAccounts)
            {
                if (item.AccountNumber == AcctNum)
                {
                    item.MakeDeposit(amt, DateTime.Now, note, item.AccountNumber, _data.allTransactions);
                }
            } 
        }

        public void MakeWidrawal()
        {
            long AcctNum;
            decimal amt;
            Console.WriteLine("Please Follow the Prompt to Withdraw from your Account");
            Console.WriteLine("Enter your Account Number");
            var acctNum = Console.ReadLine();

            AcctNum = ValidateAccountNum(acctNum, _data.bankAccounts);

            Console.WriteLine("Enter Amount to Withdraw");
            var amount = Console.ReadLine();

            Console.WriteLine("Enter Transaction Description");
            var note = Console.ReadLine();

            amt = ValidateAmount(amount);
            foreach (var item in _data.bankAccounts)
            {
                if (item.AccountNumber == AcctNum)
                {
                    item.MakeWithdrawal(amt, DateTime.Now, note, item.AccountNumber) ;
                }
            }
        }

        private long ValidateAccountNum(string AccountNum, List<BankAccount> bankAccounts )
        {
            // check if Account is a number
            long AcctNum = 0;
            bool isAcctNumValid = false;
            while (!regex.IsMatch(AccountNum))
            {
                Console.WriteLine("Account Number must be a Digit");
                    Console.WriteLine("Enter Account Number");
                AccountNum = Console.ReadLine();
            }
            while(AccountNum.Length != 10)
            {
                Console.WriteLine("Invalid Account Number, Account Number must be ten Digit");
                Console.WriteLine("Enter Account Number");
                AccountNum = Console.ReadLine();
            }
            if(long.TryParse(AccountNum, out AcctNum))
            {
                foreach (var item in bankAccounts)
                {
                    if(item.AccountNumber == AcctNum)
                    {
                        isAcctNumValid = true;
                    }
                }
            }
            return AcctNum;
        }

        private decimal ValidateAmount(string amount)
        {
            // check if Amount valid
            decimal amt = 0;
            
           
            while(Decimal.TryParse(amount, out amt))
            {
                Console.WriteLine("Amount is not valid");
                Console.WriteLine("Enter Amount");
                amount = Console.ReadLine();
            }
           
            return amt;
        }

      
    } 
}










    
 
