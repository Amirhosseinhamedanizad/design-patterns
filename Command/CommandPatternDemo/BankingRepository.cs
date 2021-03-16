using System;

namespace CommandPatternDemo
{
    public interface IBankingRepository
    {
        void Transfer(string from, string to, decimal amoount);
        void Withdraw(string person, decimal amount);
    }

    public class BankingRepository : IBankingRepository
    {
        public void Transfer(string from, string to, decimal amount)
        {
            //TODO: later we need to write it into the DB
            Console.WriteLine($"Money has been transfered from {from} to {to} with the amount of {amount.ToString("C")}");
        }

        public void Withdraw(string person, decimal amount)
        {
            Console.WriteLine($"Money withdrawn by {person} with the amount of {amount.ToString("C")}");
        }
    }
}
