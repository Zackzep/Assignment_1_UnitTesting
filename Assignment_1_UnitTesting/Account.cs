using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_UnitTesting
{
    public abstract class Account
    {
        public double _balance = 300;

        protected Account(double balance)
        {
            _balance = balance;
        }
        public Account()
        {

        }

        public double Balance { get => _balance; protected set => _balance = value; }

        public abstract void Deposit(double value);

        



        public abstract bool Withdraw(double amount);
        
            
        
    }

    
    
}
