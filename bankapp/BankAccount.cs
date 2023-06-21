using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankapp
{
    public abstract class BankAccount
    {
        public long AccountNumber { get; set; }
        public User Owner{ get; set; }
        public string AccountType{ get; set; }
        public decimal Balance {
            get;set;
            
                //decimal balance = 0;
                //foreach (var item in allTransactions)
                //{
                //    balance += item.Amount;
                //}
                //return balance; 

           
        
        
        }

        private static long  accountNumberSeed = 39167987980;

       

       //private decimal getBalance()

       public void MakeDeposit(decimal amount, DateTime date, string note, long AcctNum, List<Transaction> allTransactions)
        {
            if (amount <= 0)
            {
                throw new ArugumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");

            }  
            var deposit = new Transaction(amount, date, note, AcctNum);
            allTransactions.Add(deposit);

            Balance += amount;
        }
        public  virtual void MakeWithdrawal(decimal amount,DateTime date, string note, long accountNumber)
        {
            
           
            
        }
        public void GenerateAccountNumber(List<BankAccount> bankAccounts)
        {
           if(bankAccounts.Count == 0)
            {
                AccountNumber = accountNumberSeed;
            }
            else
            {
                var prevAcctNum  = bankAccounts[bankAccounts.Count - 1].AccountNumber;
                AccountNumber = prevAcctNum + 1;
            }
            

        }
    }
}
