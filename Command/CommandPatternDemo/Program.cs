using System;

namespace CommandPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("From Person:");
            string from = Console.ReadLine();

            Console.WriteLine("To Person:");
            string to = Console.ReadLine();

            Console.WriteLine("How much ?");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            var transferCommand = new TransferCommand { FromPerson = from, ToPerson = to, Amount = amount };

            new TransferCommandHandler(new BankingRepository()).Handle(transferCommand);

            Console.WriteLine("Person:");
            string person = Console.ReadLine();

            Console.WriteLine("How much ?");
            amount = Convert.ToDecimal(Console.ReadLine());

            var withdrawCommand = new WithdrawCommand { Person = person, Amount = amount };
            new WithdrawCommandHandler(new BankingRepository()).Handle(withdrawCommand);
            Console.ReadLine();
        }
    }
}
