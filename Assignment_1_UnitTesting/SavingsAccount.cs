using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_UnitTesting
{
    public class SavingsAccount : Account
    {
        
        public SavingsAccount(double balance) : base(balance)
        {

        }
        public override void Deposit(double value)
        {
            double newValue = Balance += value;
            if (newValue > 0)
            {
                return;
            }
        }
        public override bool Withdraw(double value)
        {
            if (value >= 0 && Balance >= value)
            {
                Balance -= value;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
