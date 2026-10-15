using System;

namespace BankingApp
{
    public abstract class Account
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; protected set; }
        public abstract string AccountType { get; }

        public Account(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0m;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0m)
            {
                throw new BankingException("Deposit amount must be greater than zero.");
            }

            Balance = Balance + amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0m)
            {
                throw new BankingException("Withdrawal amount must be greater than zero.");
            }

            if (amount > Balance)
            {
                throw new BankingException("Withdrawal declined. Insufficient funds in your " + AccountType + ".");
            }

            Balance = Balance - amount;
        }

        public virtual decimal AddInterest()
        {
            return 0m;
        }

        public virtual decimal ApplyFee()
        {
            return 0m;
        }
    }

    public class EverydayAccount : Account
    {
        public override string AccountType { get { return "Everyday Account"; } }

        public EverydayAccount(string accountNumber) : base(accountNumber)
        {
        }

        public override decimal ApplyFee()
        {
            decimal fee = 2m;

            if (Balance < fee)
            {
                throw new BankingException("Everyday Account needs at least $2.00 to pay the fee.");
            }

            Balance = Balance - fee;
            return fee;
        }
    }

    public class InvestmentAccount : Account
    {
        public override string AccountType { get { return "Investment Account"; } }

        public InvestmentAccount(string accountNumber) : base(accountNumber)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0m)
            {
                throw new BankingException("Withdrawal amount must be greater than zero.");
            }

            if (amount > Balance)
            {
                throw new BankingException("Withdrawal declined. Your Investment Account balance is too low.");
            }

            Balance = Balance - amount;
        }

        public override decimal AddInterest()
        {
            decimal interest = Math.Round(Balance * 0.05m, 2);
            Balance = Balance + interest;
            return interest;
        }
    }

    public class OmniAccount : Account
    {
        public override string AccountType { get { return "Omni Account"; } }
        public decimal OverdraftLimit { get { return 500m; } }

        public OmniAccount(string accountNumber) : base(accountNumber)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0m)
            {
                throw new BankingException("Withdrawal amount must be greater than zero.");
            }

            if (Balance - amount < -OverdraftLimit)
            {
                throw new BankingException("Withdrawal declined. Omni Account overdraft limit is $500.00.");
            }

            Balance = Balance - amount;
        }

        public override decimal ApplyFee()
        {
            decimal fee = 5m;

            if (Balance - fee < -OverdraftLimit)
            {
                throw new BankingException("Omni Account fee cannot exceed the overdraft limit.");
            }

            Balance = Balance - fee;
            return fee;
        }
    }
}
