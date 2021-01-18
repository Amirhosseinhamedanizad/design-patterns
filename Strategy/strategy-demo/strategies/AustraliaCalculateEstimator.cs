
namespace strategy_demo.strategies
{
    public class AustraliaCalculateEstimator : ICostCalculator
    {
        public double CalculateProductCost(Product item)
        {
            return item.Weight * 0.8 + 10;
        }
    }
}
