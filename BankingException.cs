using System;

namespace BankingApp
{
    public class BankingException : Exception
    {
        public BankingException(string message) : base(message)
        {
        }
    }
}
