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
    public class CheckingAccountTests
    {
        CheckingAccount _checkingAccount;

        public CheckingAccountTests()
        {
            _checkingAccount = new CheckingAccount();
        }
        [TestMethod()]
        public void DepositTest()
        {
			double number = 5;
			double startingValue = _checkingAccount.Balance;
			double expectedResult = _checkingAccount.Balance + 5;

			_checkingAccount.Deposit(number);
			double result = _checkingAccount.Balance;

			Assert.IsTrue(result == expectedResult);
		}

        [TestMethod()]
        public void WithdrawTest()
        {
			double number = 5;
			double startingValue = _checkingAccount.Balance;
			double expectedResult = _checkingAccount.Balance - 5;

			_checkingAccount.Withdraw(number);
			double result = _checkingAccount.Balance;

			Assert.IsTrue(result == expectedResult);
		}
    }
}