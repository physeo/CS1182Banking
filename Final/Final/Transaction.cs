using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Transaction
    {
        decimal transactionAmount;
        DateTime transactionDate;

        public Transaction()
        {
            transactionAmount = 0;
            transactionDate = new DateTime();
        }

        public Transaction(decimal _transactionAmount)
        {
            TransactionAmount = _transactionAmount;
            transactionDate = new DateTime();
        }

        public decimal TransactionAmount
        {
            get { return transactionAmount; }
            set
            {
                transactionAmount = value;
            }
        }

        public DateTime TransactionDate
        {
            get { return transactionDate; }
        }
    }
}
