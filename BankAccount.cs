using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceConstructors
{
    internal class BankAccount
    {
        string _accountNumber;
        string _cusomerName;
        double _balance;

        public BankAccount(string accountNumber, string cusomerName, double balance)
        {
            _accountNumber = accountNumber;
            _cusomerName = cusomerName;
            _balance = balance;
        }

        public string AccountNumber { get => _accountNumber;  }
        public string CusomerName { get => _cusomerName; set => _cusomerName = value; }
        public double Balance { get => _balance;  }


        public void Deposit(int dep)
        {
            if(dep>=0)
            _balance += dep;
        }

        public void Withdraw(int wtd)
        {
            if (wtd >= 0 && wtd < _balance)
                _balance -= wtd;
        }

        public override string ToString()
        {
            return "Account Number:" + AccountNumber + " -" + CusomerName + " " + "Current Balance-"+Balance;
        }
    }
}
