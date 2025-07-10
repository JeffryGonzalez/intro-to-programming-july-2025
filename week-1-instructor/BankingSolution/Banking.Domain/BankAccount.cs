


namespace Banking.Domain;


public enum AccountTypes {  StandardAccount, GoldAccount, PlatinumAccount }
public class BankAccount
{


    private decimal _currentBalance = 7000;
    public void Deposit(TransactionAmount amountToDeposit, AccountTypes accountType = AccountTypes.StandardAccount)
    {

        switch (accountType)
        {

            case AccountTypes.GoldAccount:
                _currentBalance += amountToDeposit * 1.10M;
                return;
            case AccountTypes.PlatinumAccount:
                _currentBalance += amountToDeposit * 1.15M;
                return;
            default:
                _currentBalance += amountToDeposit;
                return;
        }
       
    }



    public decimal GetBalance() 
    {
        
        return _currentBalance;
    }

    public void Withdraw(TransactionAmount amountToWithdraw)
    {
       _currentBalance -= amountToWithdraw;
    }

  
}