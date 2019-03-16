using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Checking : IAccount
    {
        List<Transaction> deposit;
        List<Transaction> withdrawal;


        public List<Transaction> Deposit
        {
            get { return deposit; }
        }

        public List<Transaction> Withdrawal
        {
            get { return withdrawal; }
        }

        public override decimal getBalance()
        {
            decimal balance = 0;

            return balance;
        }
    }
}
