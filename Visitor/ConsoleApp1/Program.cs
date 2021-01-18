using System;
using System.Collections.Generic;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paitient-Checker
            //List<IElement> elements = new List<IElement>() {
            //    new HIVPaiteint("Alireza"),
            //    new HIVPaiteint("Lucas")
            //};

            //var visitor = new CheckupOperator();

            //foreach (var element in elements)
            //{
            //    element.Accept(visitor);
            //}

            //Console.ReadLine();



            List<Asset> assets = new List<Asset>()
            {
            new BankAccount(),
            new Car(),
            new RealState()
            };

            var calculator = new LoanCalculator();

            assets.ForEach(asset => asset.AcceptVisitor(calculator));

            Console.ReadKey();
        }

    }
}
