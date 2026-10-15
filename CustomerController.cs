using System;
using System.Collections.Generic;

namespace BankingApp
{
    public class CustomerController
    {
        private List<Customer> customers = new List<Customer>();

        public bool AddCustomer(string number, string name, string contact, bool isBankStaff)
        {
            CheckDetails(number, name, contact);
            number = number.Trim();

            if (GetCustomer(number) != null)
            {
                throw new BankingException("This customer number already exists.");
            }

            customers.Add(new Customer(number, name.Trim(), contact.Trim(), isBankStaff));
            return true;
        }

        public Customer GetCustomer(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                return null;
            }

            foreach (Customer customer in customers)
            {
                if (string.Equals(customer.CustomerNumber, number.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return customer;
                }
            }

            return null;
        }

        public List<Customer> GetAllCustomers()
        {
            return new List<Customer>(customers);
        }

        public bool UpdateCustomer(string number, string name, string contact, bool isBankStaff)
        {
            CheckDetails(number, name, contact);
            Customer customer = GetRequiredCustomer(number);
            customer.Name = name.Trim();
            customer.Contact = contact.Trim();
            customer.IsBankStaff = isBankStaff;
            return true;
        }

        public bool DeleteCustomer(string number)
        {
            Customer customer = GetRequiredCustomer(number);
            customers.Remove(customer);
            return true;
        }

        public List<Account> GetCustomerAccounts(string number)
        {
            Customer customer = GetRequiredCustomer(number);
            return new List<Account>(customer.Accounts);
        }

        public string GetAccountNumber(string number, string accountType)
        {
            return FindAccount(number, accountType).AccountNumber;
        }

        public decimal GetAccountBalance(string number, string accountType)
        {
            return FindAccount(number, accountType).Balance;
        }

        public List<string> GetHistory(string number)
        {
            Customer customer = GetRequiredCustomer(number);
            return new List<string>(customer.History);
        }

        public void Deposit(string number, string accountType, decimal amount)
        {
            Account account = FindAccount(number, accountType);
            account.Deposit(amount);
            GetRequiredCustomer(number).History.Add("Deposit $" + amount.ToString("0.00") + " to " + account.AccountNumber);
        }

        public void Withdraw(string number, string accountType, decimal amount)
        {
            Account account = FindAccount(number, accountType);
            account.Withdraw(amount);
            GetRequiredCustomer(number).History.Add("Withdraw $" + amount.ToString("0.00") + " from " + account.AccountNumber);
        }

        public decimal AddInterest(string number, string accountType)
        {
            Account account = FindAccount(number, accountType);
            decimal interest = account.AddInterest();

            if (interest > 0m)
            {
                GetRequiredCustomer(number).History.Add("Interest $" + interest.ToString("0.00") + " to " + account.AccountNumber);
            }

            return interest;
        }

        public decimal ApplyFee(string number, string accountType)
        {
            Account account = FindAccount(number, accountType);
            decimal fee = account.ApplyFee();

            if (fee > 0m)
            {
                GetRequiredCustomer(number).History.Add("Fee $" + fee.ToString("0.00") + " from " + account.AccountNumber);
            }

            return fee;
        }

        private Customer GetRequiredCustomer(string number)
        {
            Customer customer = GetCustomer(number);

            if (customer == null)
            {
                throw new BankingException("Customer not found. Please check the customer number.");
            }

            return customer;
        }

        private Account FindAccount(string number, string accountType)
        {
            Customer customer = GetRequiredCustomer(number);

            foreach (Account account in customer.Accounts)
            {
                if (account.AccountType == accountType)
                {
                    return account;
                }
            }

            throw new BankingException("Please select an account type.");
        }

        private void CheckDetails(string number, string name, string contact)
        {
            if (string.IsNullOrWhiteSpace(number) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(contact))
            {
                throw new BankingException("Customer number, name and contact are required.");
            }
        }
    }
}
