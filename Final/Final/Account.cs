using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Account : IEquatable<Account>
    {
        int accountNumber;
        Checking checkingAccount;
        Customer customer;
        List<Loan> loanAccounts;
        Savings savingsAccount;

        public Account()
        {
            accountNumber = 0;
            checkingAccount = new Checking();
            customer = new Customer();
            loanAccounts = new List<Loan>();
            savingsAccount = new Savings();
        }

        public Account(int _accountNumber)
        {
            AccountNumber = _accountNumber;
            checkingAccount = new Checking();
            customer = new Customer();
            loanAccounts = new List<Loan>();
            savingsAccount = new Savings();
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set
            {
                accountNumber = value;
            }
        }

        public Checking CheckingAccount
        {
            get { return checkingAccount; }
        }

        public Customer Customer
        {
            get { return customer; }
        }

        public List<Loan> LoanAccounts
        {
            get { return loanAccounts; }
        }

        public Savings SavingsAccount
        {
            get { return savingsAccount; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Account objAsAccount = obj as Account;
            if (objAsAccount == null)
            {
                return false;
            }
            else
            {
                return Equals(objAsAccount);
            }
            
        }

        public bool Equals(Account otherAccount)
        {
            if (otherAccount == null)
            {
                return false;
            }
            return (this.accountNumber.Equals(otherAccount.accountNumber));

        }

        public override int GetHashCode()
        {
            return accountNumber;
        }
    }
}
