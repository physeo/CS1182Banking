using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Loan : IAccount
    {
        decimal loanAmount;
        DateTime loanDate;
        string loanMonths;
        int loanNumber;
        double loanRate;
        string loanType;
        List<Transaction> payments;


        public Loan()
        {
            loanAmount = 0;
            loanDate = new DateTime();
            loanMonths = "";
            loanNumber = 0;
            loanRate = 0.0;
            loanType = "";
            payments = new List<Transaction>();
        }

        public Loan(decimal _loanAmount, string _loanMonths, int _loanNumber
           , double _loanRate, string _loanType)
        {
            LoanAmount = _loanAmount;
            loanDate = new DateTime();
            LoanMonths = _loanMonths;
            LoanNumber = _loanNumber;
            LoanRate = _loanRate;
            LoanType = _loanType;
            payments = new List<Transaction>();
        }

        public decimal LoanAmount
        {
            get { return loanAmount; }
            set
            {
                loanAmount = value;
            }
        }

        public DateTime LoanDate
        {
            get { return loanDate; }
        }

        public string LoanMonths
        {
            get { return loanMonths; }
            set
            {
                loanMonths = value;
            }
        }

        public int LoanNumber
        {
            get { return loanNumber; }
            set
            {
                loanNumber = value;
            }
        }

        public double LoanRate
        {
            get { return loanRate; }
            set
            {
                loanRate = value;
            }
        }

        public string LoanType
        {
            get { return loanType; }
            set
            {
                loanType = value;
            }
        }

        public List<Transaction> Payments
        {
            get { return payments; }
        }

        public override decimal getBalance()
        {
            decimal balance = 0;

            return balance;
        }
    }
}
