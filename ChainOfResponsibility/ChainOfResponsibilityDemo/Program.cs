using ChainOfResponsibilityDemo.Models;
using System;

namespace ChainOfResponsibilityDemo
{
    class Program
    {
        //more resources
        //https://dotnettutorials.net/lesson/chain-of-responsibility-design-pattern/
        //https://codewithshadman.com/chain-of-responsibility-pattern-csharp/
        static void Main(string[] args)
        {
            var user = new User
            {
                Name = "Alireza",
                Region = "CA",
                SSN = "111222333",
                Age = 19
            };

            var processor = new UserProcessor_Clean();
            processor.Register(user);

            Console.ReadKey();

        }
    }
}
