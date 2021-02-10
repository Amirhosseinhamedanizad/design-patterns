using DecoratorDemo.Decorators;
using System;

namespace DecoratorDemo
{
    public class Mathematic : IComponent
    {
        public void Operation()
        {
            //Do Mathematic Operation
            Console.WriteLine("Doing intensive mathematic operation");
        }
    }
}
