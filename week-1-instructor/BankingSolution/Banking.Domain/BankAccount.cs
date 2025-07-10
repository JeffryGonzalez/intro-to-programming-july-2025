


namespace Banking.Domain;

public class BankAccount
{


    private decimal _currentBalance = 7000;
    public void Deposit(TransactionAmount amountToDeposit)
    {

        //_currentBalance = _currentBalance + amountToDeposit;
        _currentBalance += amountToDeposit + 10;
       
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