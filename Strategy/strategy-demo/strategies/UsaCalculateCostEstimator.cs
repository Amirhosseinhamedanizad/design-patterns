
namespace strategy_demo.strategies
{
    class UsaCalculateCostEstimator : ICostCalculator
    {
        public double CalculateProductCost(Product item)
        {
            return item.Weight * 0.9 + 20;
        }
    }
}
