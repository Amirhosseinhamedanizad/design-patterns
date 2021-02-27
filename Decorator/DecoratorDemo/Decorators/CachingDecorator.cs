using System;

namespace DecoratorDemo.Decorators
{
    public class CachingDecorator : IComponent
    {
        private readonly IComponent _component;
        public CachingDecorator(IComponent component)
        {
            _component = component;
        }
        public void Operation()
        {
            Console.WriteLine("Caching started ...");
            _component.Operation();
            Console.WriteLine("Caching ended ...");
        }
    }
}
