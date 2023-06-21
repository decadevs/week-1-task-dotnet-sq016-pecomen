using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankapp
{
    public  class Data
    {
        public List<Transaction> allTransactions { get; set; }
        public List<BankAccount> bankAccounts { get; set; }   


        public Data()
        {
            allTransactions = new List<Transaction>();
            bankAccounts = new List<BankAccount>();         
        }
    }
}
