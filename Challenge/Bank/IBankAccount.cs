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
            var fee = CalculateFee(amount, WithDrawType.Transfer);
            if (UpdateBalance(amount + fee))
            {
                otherAccount.DepositMoney(amount);
            }


            return true;
        }

        private bool UpdateBalance(decimal amount)
        {
            if (amount < balance)
            {
                balance -= amount;
                return true;
            }

            return false;
        }
        public bool WithDrawMoney(decimal amount)
        {
            var fee = CalculateFee(amount, WithDrawType.Withdrawal);
            return UpdateBalance(amount + fee);
        }

        private static decimal CalculateFee(decimal amount, WithDrawType type)
        {

            switch (type)
            {
                case WithDrawType.Transfer:
                    return amount * .10m;
                case WithDrawType.Withdrawal:
                    return amount * .05m;
                default:
                    return 0;
            }
        }
    }

    public enum WithDrawType
    {
        Transfer,
        Withdrawal
    }
}