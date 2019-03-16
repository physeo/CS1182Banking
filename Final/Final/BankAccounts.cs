using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class BankAccounts
    {
        static List<Account> memberAccounts;

        public static List<Account> MemberAccounts
        {
            get { return memberAccounts; }
        }

        public static void addNewAccount(Account _newAccount)
        {
            memberAccounts = new List<Account>();

            memberAccounts.Add(_newAccount);
        }

        public static Account getAccount(int _accountNumber)
        {
            return memberAccounts.Find(x => x.AccountNumber.Equals(_accountNumber));
        }

        // public List<Account> readAccounts()
        //{

        //}

        public static void saveAccounts()
         {

         }
    }
}
