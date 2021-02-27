using System;

namespace ObserverDemo.Companies
{
    public class CompanyC : Observer
    {
        public void Update(double price)
        {
            Console.WriteLine($"Company C received {price} to do its internal activities");
        }
    }
}
