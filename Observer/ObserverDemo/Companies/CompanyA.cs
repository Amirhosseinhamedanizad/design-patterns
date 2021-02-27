using System;

namespace ObserverDemo.Companies
{
    public class CompanyA : Observer
    {
        public void Update(double price)
        {
            Console.WriteLine($"Company A received {price} to do its internal activities");
        }
    }
}
