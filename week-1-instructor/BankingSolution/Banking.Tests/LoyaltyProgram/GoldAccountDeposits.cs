

using Banking.Domain;

namespace Banking.Tests.LoyaltyProgram;
public class GoldAccountDeposits
{

    [Fact]
    public void GoldAccountsGetABonusOnTheirDeposits()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        account.Deposit(100M);

        Assert.Equal(openingBalance + 110M, account.GetBalance());
        
    }
}
