using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Account
    {
        public int AccountNumber { get; }
        public string Password { get; }
        public decimal Balance { get; private set; }

        public Account(int accountNumber, string password, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Password = password;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

    }
}
