using strategy_demo.strategies;
using System;

namespace strategy_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select which country you want?");
            var selectedCountry = Console.ReadLine();
            var product = new Product();

            //china
            ICostCalculator china_costCalculator = new ChinaCalculateCostEstimator();
            var china_cost = china_costCalculator.CalculateProductCost(product);

            //australia
            ICostCalculator aus_costCalculator = new AustraliaCalculateEstimator();
            var aus_cost = aus_costCalculator.CalculateProductCost(product);


            //usa
            ICostCalculator usa_costCalculator = new AustraliaCalculateEstimator();
            var usa_cost = usa_costCalculator.CalculateProductCost(product);

            //var finalCost = CalculateProductCost(selectedCountry, product);
            //Console.WriteLine($"Final Cost is: { finalCost}");

            //depends on settings in application one of the costs would be rendered
            if (selectedCountry == "china")
                Console.WriteLine($"Final Cost is: { china_cost}");

            if (selectedCountry == "australia")
                Console.WriteLine($"Final Cost is: { aus_cost}");

            if (selectedCountry == "usa")
                Console.WriteLine($"Final Cost is: { usa_cost}");
        }

        //private static double CalculateProductCost(string selectedCountry, ICostCalculator costCalculator)
        //{
        //    double finalCost = 0;
        //    //Problem: calculate product cost base on weight and country
        //    switch(selectedCountry)
        //    {
        //        case "china":
        //            finalCost = item.Weight * 0.2;
        //            break;
        //        case "australia":
        //            finalCost = item.Weight * 0.8 + 10;
        //            break;
        //        case "usa":
        //            finalCost = item.Weight * 0.9 + 20;
        //            break;
        //        //violate open-closed principle
        //        //case "iran":
        //        //    finalCost = item.Weight * .3;
        //        //    break;
        //        default:
        //            throw new InvalidOperationException();
        //    }

        //    return finalCost;
    }
}
