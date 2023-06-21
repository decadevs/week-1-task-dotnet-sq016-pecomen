 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankapp
{
    public class Transaction
    {
        public decimal Amount { get; } 
        public DateTime Date { get; } 
        public string Notes { get; }
        public long AccountNumber { get; set; }
        public Transaction(decimal amount,DateTime date, string note, long AcctNum)
        {
            this.Amount = amount;    
            this.Date = date;
            this.Notes = note;
            this.AccountNumber = AcctNum;
        }
    }
}
