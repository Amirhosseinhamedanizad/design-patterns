using System;

namespace ObserverDemo.Companies
{
    public class CompanyB : Observer
    {
        public void Update(double price)
        {
            Console.WriteLine($"Company B received {price} to do its internal activities");
        }
    }
}
