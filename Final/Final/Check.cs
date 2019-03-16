using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Check : Transaction
    {
        DateTime checkDate;
        int checkNumber;

        public Check()
            : base()
        {
            checkNumber = 0;
            checkDate = new DateTime();
        }

        public Check(int _checkNumber, decimal _transactionAmount)
            : base(_transactionAmount)
        {
            CheckNumber = _checkNumber;
            checkDate = new DateTime();
        }

        public DateTime CheckDate
        {
            get { return checkDate; }
        }

        public int CheckNumber
        {
            get { return checkNumber; }
            set
            {
                checkNumber = value;
            }
        }
    }
}
