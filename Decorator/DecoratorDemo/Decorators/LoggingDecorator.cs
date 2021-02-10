using System;

namespace DecoratorDemo.Decorators
{
    public class LoggingDecorator : IComponent
    {
        private readonly IComponent _component;
        public LoggingDecorator(IComponent component)
        {
            _component = component;
        }
        public void Operation()
        {
            Console.WriteLine("Log started ...");
            _component.Operation();
            Console.WriteLine("log ended ...");
        }
    }
}
