using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_UnitTesting
{
    public abstract class Account
    {
        double _balance;

        protected Account(double balance)
        {
            _balance = balance;
        }

        public double Balance { get => _balance; protected set => _balance = value; }
    }

    abstract void Deposit(double value)
    {
        double newBalance = Balance += value;
        return newBalance;
        
    }
    abstract void Withdraw(double amount)
    {
        double newBalance = Balance -= amount;
        return newBalance;
    }
}
