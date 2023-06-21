using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankapp
{
    public class CurrentAccount:BankAccount
    {
        private readonly Data _data;

        public CurrentAccount(User name, decimal initialBalance, Data data)
        {
            base.AccountType = "current";
            base.Owner = name;
            _data = data;
            base.GenerateAccountNumber(_data.bankAccounts);

            base.MakeDeposit(initialBalance, DateTime.Now, "Initial Balance", base.AccountNumber, _data.allTransactions);


        }

        public override void MakeWithdrawal(decimal amount, DateTime date, string note, long accountNumber)
        {
            if (amount <= 0)
            {
                throw new ArugumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");

            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withDrawal");

            }
            var withdrawal = new Transaction(-amount, date, note, accountNumber);
            _data.allTransactions.Add(withdrawal);
            base.Balance -= amount;
        }
    }
}
