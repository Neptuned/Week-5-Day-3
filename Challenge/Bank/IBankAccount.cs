using System;

namespace Bank
{
    public interface IBankAccount
    {
        bool DepositMoney(decimal amount);
        bool WithDrawMoney(decimal amount);
        bool TransferMoney(IBankAccount otherAccount, decimal amount);

        Decimal Balance { get; }
    }

    public class CheckingAccount : IBankAccount
    {
        private decimal balance;
        public CheckingAccount(int startingBalance)
        {
            balance = startingBalance;

        }

        public decimal Balance
        {
            get
            {
              return balance;
            }
        }

        public bool DepositMoney(decimal amount)
        {
            balance += amount;
            return true;
        }

        public bool TransferMoney(IBankAccount otherAccount, decimal amount)
        {
            this.WithDrawMoney(amount);
            otherAccount.DepositMoney(amount);
            return true;
        }

        public bool WithDrawMoney(decimal amount)
        {
            balance -= amount;
            return true;
        }
    }

    public class SavingsAccount : IBankAccount
    {
        private decimal balance;

        public SavingsAccount(int startingBalance)
        {
            balance = startingBalance;
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public bool DepositMoney(decimal amount)
        {
            balance += amount;
            return true;

        }

        public bool TransferMoney(IBankAccount otherAccount, decimal amount)
        {
            throw new NotImplementedException();
        }

        public bool WithDrawMoney(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}