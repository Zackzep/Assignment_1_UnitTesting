using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_1_UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_UnitTesting.Tests
{
    [TestClass()]
    public class SavingsAccountTests
    {
        SavingsAccount _savingsAccount;

        public SavingsAccountTests()
        {
            _savingsAccount = new SavingsAccount();
        }
        [TestMethod()]
        public void WithdrawTest()
        {
            double number = 5;
            double result = _savingsAccount.Withdraw(number);

            Assert.IsTrue(result == number);

            Assert.IsFalse(result != number);
        }

        [TestMethod()]
        public void DepositTest()
        {
            double number = 5;
            double result = _savingsAccount.Deposit(number);

            Assert.IsTrue(result == number);

            Assert.IsFalse(result != number);
        }
    }
}