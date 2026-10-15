using System.Collections.Generic;

namespace BankingApp
{
    public class Customer
    {
        public string CustomerNumber { get; private set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public bool IsBankStaff { get; set; }
        public List<Account> Accounts { get; private set; }
        public List<string> History { get; private set; }

        public Customer(string customerNumber, string name, string contact, bool isBankStaff)
        {
            CustomerNumber = customerNumber;
            Name = name;
            Contact = contact;
            IsBankStaff = isBankStaff;
            Accounts = new List<Account>();
            History = new List<string>();

            Accounts.Add(new EverydayAccount(customerNumber + "-E"));
            Accounts.Add(new InvestmentAccount(customerNumber + "-I"));
            Accounts.Add(new OmniAccount(customerNumber + "-O"));
        }
    }
}
