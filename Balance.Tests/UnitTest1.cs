using NUnit.Framework;
using System;

namespace Balance.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {        }

        [Test]
        public void Test_BalanceCheckPositive_shouldBeTrue() 
        {
            var balance = new Balance();

            Assert.True(balance.balanceInformation >= 0);
        }

        [Test]
        public void Test_BalanceCheckType_shouldBeDecimal() 
        {
            var balance = new Balance();
            var typeCheck = balance.GetType();

            Assert.That(balance.balanceInformation, Is.TypeOf<Decimal>());
        }

        [Test]
        public void Test_IncomesAddToBalance_BalanceShouldUpdate() 
        {
            var account = new Balance();
            account.addToBalance = 20;

            Assert.AreEqual(20, account.balanceInformation);
        }

        [Test]
        public void Test_IncomesAddToBalance_BalanceShouldNOTUpdate() 
        {
            var account = new Balance();
            account.addToBalance = -20;

            Assert.AreEqual(0, account.balanceInformation);
        }

        [Test]
        public void Test_WithdrawalSubtractFromBalance_BalanceShouldUpdate()
        {
            var account = new Balance();
            account.subtractFromBalance = 100;
            account.subtractFromBalance = 80;

            Assert.AreEqual(-180, account.balanceInformation);
        }

        [Test]
        public void Test_WithdrawalSubtractFromBalance_BalanceShouldNOTUpdate()
        {
            var account = new Balance();
            account.subtractFromBalance = 150;

            Assert.AreEqual(0, account.balanceInformation);
        }
    }
}