using ObserverDemo.Companies;
using System;

namespace ObserverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyA companyA = new CompanyA();
            CompanyB companyB = new CompanyB();
            CompanyC companyC = new CompanyC();

            Subject subject = new Subject();
            subject.addObserver(companyA);
            subject.addObserver(companyB);
            subject.addObserver(companyC);

            Console.WriteLine("enter price");
            var price = Convert.ToDouble(Console.ReadLine());
            subject.notifyObserver(price);

            Console.ReadKey();
        }
    }
}
