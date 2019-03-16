using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Cash : Transaction
    {
        public Cash()
            : base()
        {

        }

        public Cash(decimal _transactionAmount)
            : base(_transactionAmount)
        {

        }

    }
}
