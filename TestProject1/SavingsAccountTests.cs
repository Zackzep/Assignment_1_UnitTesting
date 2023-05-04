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
			double startingValue = _savingsAccount.Balance;
			double expectedResult = _savingsAccount.Balance - 5;

			_savingsAccount.Withdraw(number);
			double result = _savingsAccount.Balance;

			Assert.IsTrue(result == expectedResult);

            
        }

        [TestMethod()]
        public void DepositTest()
        {
            // Arrange
            double number = 5;
            double startingValue = _savingsAccount.Balance;
            double expectedResult = _savingsAccount.Balance + 5;

			//ACT
			// Your trying to get the result AFTER you've deposited - ACT
			_savingsAccount.Deposit(number);
            double result = _savingsAccount.Balance;

            // Assert
            Assert.IsTrue(result == expectedResult);

            
        }
    }
}