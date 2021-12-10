using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11
{
    class BankAccount
    {
        private Type accountType;
        private decimal balance;
        private static long id = 0;
        private long number;
        public long ID()
        {
            return id++;
        }
        internal BankAccount()
        {
            number = ID();
        }
        internal BankAccount(decimal balance)
        {
            number = ID();
            this.balance = balance;
        }
        internal BankAccount(Type accountType)
        {
            number = ID();
            this.accountType = accountType;
        }
        internal BankAccount(decimal balance, Type accountType)
        {
            this.accountType = accountType;
            this.balance = balance;
        }

        public void WithDraw(decimal sum)
        {
            if (sum <= balance)
            {
                balance -= sum;
            }
            else
            {
                Console.WriteLine("на вашем счету недостаточно средств");
            }
        }
        public void Deposit(decimal sum)
        {
            balance += sum;
        }
        public override string ToString()
        {
            string s = "номер счета: " + number + " баланс:  " + balance.ToString() + " тип счета: " + accountType;
            return s;
        }
        public override bool Equals(object o)
        {
            if (o == null)
            {
                return false;
            }
            BankAccount account = o as BankAccount;
            if (account != null && account.accountType == accountType && account.balance == balance)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(BankAccount acc1, BankAccount acc2)
        {
            if (acc1.Equals(acc2) && acc2.Equals(acc1))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(BankAccount acc1, BankAccount acc2)
        {
            if (acc1.Equals(acc2) && acc2.Equals(acc1))
            {
                return false;
            }
            return true;
        }

    }
}

