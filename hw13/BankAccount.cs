using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13
{ 
 class BankAccount
{
    private Type accountType;
    private decimal balance;
    private static long id = 0;
    private long number;
    public long Number => number;
    public decimal Balance => balance;
    public Type AccountType => accountType;
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
    public void Print()
    {
        Console.WriteLine("Номер счета:" + number);
        Console.WriteLine("Баланс счета" + balance);
        Console.WriteLine("Тип счета:" + accountType);
    }
}
}


