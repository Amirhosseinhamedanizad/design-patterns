using DecoratorDemo.Decorators;
using System;

namespace DecoratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematic mathematic = new Mathematic();
            CachingDecorator caching = new CachingDecorator(mathematic);
            LoggingDecorator logging = new LoggingDecorator(caching);

            logging.Operation();
            Console.ReadLine();
        }
    }
}
