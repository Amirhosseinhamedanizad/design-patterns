
namespace ObserverDemo.Companies
{
    public class WallStreet: Subject
    {
        private double updatedPrice;

        public double getValue() => updatedPrice;

        public void setValue(double price)
        {
            this.updatedPrice = price;
            notifyObserver(this.updatedPrice);
        }
    }
}
