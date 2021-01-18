using System;
using System.Collections.Generic;
using System.Text;

namespace strategy_demo.strategies
{
    public class ChinaCalculateCostEstimator : ICostCalculator
    {
        public double CalculateProductCost(Product item)
        {
            return item.Weight * 0.2;
        }
    }
}
