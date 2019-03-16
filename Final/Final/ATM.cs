using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class ATM : Transaction
    {
        int ATMnumber;

        public ATM()
            : base()
        {
            ATMnumber = 0;
        }

        public ATM(int _ATMnumber, decimal _transactionAmount)
            : base(_transactionAmount)
        {
            ATMNumber = _ATMnumber;
        }

        public int ATMNumber
        {
            get { return ATMnumber; }
            set
            {
                ATMnumber = value;
            }
        }
    }
}
