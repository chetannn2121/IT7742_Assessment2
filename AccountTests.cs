using BankingApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Principal;

namespace BankingApp.Tests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void EverydayDepositAddsMoney()
        {
            EverydayAccount account = new EverydayAccount("C001-E");
            account.Deposit(100m);
            Assert.AreEqual(100m, account.Balance);
        }

        [TestMethod]
        public void InvestmentDepositUsesBaseAccountMethod()
        {
            InvestmentAccount account = new InvestmentAccount("C001-I");
            account.Deposit(100m);
            Assert.AreEqual(100m, account.Balance);
        }

        [TestMethod]
        public void OmniDepositUsesBaseAccountMethod()
        {
            OmniAccount account = new OmniAccount("C001-O");
            account.Deposit(100m);
            Assert.AreEqual(100m, account.Balance);
        }

        [TestMethod]
        public void DepositZeroThrowsException()
        {
            Account account = new EverydayAccount("C001-E");
            Assert.ThrowsException<BankingException>(() => account.Deposit(0m));
            Assert.AreEqual(0m, account.Balance);
        }

        [TestMethod]
        public void NegativeDepositThrowsException()
        {
            Account account = new InvestmentAccount("C001-I");
            Assert.ThrowsException<BankingException>(() => account.Deposit(-1m));
        }

        [TestMethod]
        public void EverydayWithdrawChangesBalance()
        {
            Account account = new EverydayAccount("C001-E");
            account.Deposit(500m);
            account.Withdraw(100m);
            Assert.AreEqual(400m, account.Balance);
        }

        [TestMethod]
        public void EverydayWithdrawExactBalanceWorks()
        {
            Account account = new EverydayAccount("C001-E");
            account.Deposit(500m);
            account.Withdraw(500m);
            Assert.AreEqual(0m, account.Balance);
        }

        [TestMethod]
        public void EverydayOverdrawThrowsException()
        {
            Account account = new EverydayAccount("C001-E");
            account.Deposit(50m);
            BankingException ex = Assert.ThrowsException<BankingException>(() => account.Withdraw(50.01m));
            StringAssert.Contains(ex.Message, "Everyday Account");
            Assert.AreEqual(50m, account.Balance);
        }

        [TestMethod]
        public void WithdrawZeroThrowsException()
        {
            Account account = new InvestmentAccount("C001-I");
            account.Deposit(50m);
            Assert.ThrowsException<BankingException>(() => account.Withdraw(0m));
            Assert.AreEqual(50m, account.Balance);
        }

        [TestMethod]
        public void InvestmentOverdrawShowsOwnMessage()
        {
            Account account = new InvestmentAccount("C001-I");
            account.Deposit(20m);
            BankingException ex = Assert.ThrowsException<BankingException>(() => account.Withdraw(21m));
            StringAssert.Contains(ex.Message, "Investment Account");
            Assert.AreEqual(20m, account.Balance);
        }

        [TestMethod]
        public void InvestmentInterestIsFivePercent()
        {
            Account account = new InvestmentAccount("C001-I");
            account.Deposit(200m);
            decimal interest = account.AddInterest();
            Assert.AreEqual(10m, interest);
            Assert.AreEqual(210m, account.Balance);
        }

        [TestMethod]
        public void InvestmentInterestOnZeroBalanceIsZero()
        {
            Account account = new InvestmentAccount("C001-I");
            Assert.AreEqual(0m, account.AddInterest());
        }

        [TestMethod]
        public void EverydayFeeIsTwoDollars()
        {
            Account account = new EverydayAccount("C001-E");
            account.Deposit(10m);
            decimal fee = account.ApplyFee();
            Assert.AreEqual(2m, fee);
            Assert.AreEqual(8m, account.Balance);
        }

        [TestMethod]
        public void EverydayFeeWithLowBalanceThrowsException()
        {
            Account account = new EverydayAccount("C001-E");
            account.Deposit(1m);
            Assert.ThrowsException<BankingException>(() => account.ApplyFee());
            Assert.AreEqual(1m, account.Balance);
        }

        [TestMethod]
        public void InvestmentAccountHasNoFee()
        {
            Account account = new InvestmentAccount("C001-I");
            account.Deposit(20m);
            Assert.AreEqual(0m, account.ApplyFee());
            Assert.AreEqual(20m, account.Balance);
        }

        [TestMethod]
        public void OmniCanUseFullOverdraft()
        {
            Account account = new OmniAccount("C001-O");
            account.Withdraw(500m);
            Assert.AreEqual(-500m, account.Balance);
        }

        [TestMethod]
        public void OmniOverdraftByOneCentThrowsException()
        {
            Account account = new OmniAccount("C001-O");
            BankingException ex = Assert.ThrowsException<BankingException>(() => account.Withdraw(500.01m));
            StringAssert.Contains(ex.Message, "Omni Account");
            Assert.AreEqual(0m, account.Balance);
        }

        [TestMethod]
        public void OmniFeeIsFiveDollars()
        {
            Account account = new OmniAccount("C001-O");
            account.Deposit(20m);
            Assert.AreEqual(5m, account.ApplyFee());
            Assert.AreEqual(15m, account.Balance);
        }

        [TestMethod]
        public void OmniFeeCannotBreakOverdraftLimit()
        {
            Account account = new OmniAccount("C001-O");
            account.Withdraw(498m);
            Assert.ThrowsException<BankingException>(() => account.ApplyFee());
            Assert.AreEqual(-498m, account.Balance);
        }
    }
}
