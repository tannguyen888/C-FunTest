using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAppNS;
using System.Transactions;

namespace BankApp.Tests;

[TestClass]
public class AccountTest
{
    [TestMethod]
    public void Credit_WithValidAmount_UpdatesBalance()
    {
        // Arrange
        double beginBalance = 11.99;
        double creditAmount = 5.77;

        BankAccount account = new BankAccount("Tan Phat Nguyen", beginBalance);

        account.Credit(creditAmount);
        double expected = 17.76;
        double actual = account.Balance;

        Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
    }

    [TestMethod]
    public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
    {
        double beginBalance = 15.99;
        double creditErrorRig = -100;
        BankAccount account = new BankAccount("Tan Phat Nguyen", 15.99);

      
        Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            account.Credit(creditErrorRig)
        );
    }
}