
namespace Console1
{
    public interface IVistor
    {
        void Accept(RealState home);
        void Accept(Car car);
        void Accept(BankAccount bankAccount);
        void Accept(Garage garage);
    }


    public abstract class Asset
    {
        public abstract void AcceptVisitor(IVistor vistor);
    }

    public class Garage : Asset
    {
        public decimal Price { get; set; }
        public override void AcceptVisitor(IVistor vistor)
        {
            vistor.Accept(this);
        }
    }

    public class BankAccount : Asset
    {
        public decimal Price { get; set; }
        public override void AcceptVisitor(IVistor vistor)
        {
            vistor.Accept(this);
        }
    }

    public class Car : Asset
    {
        public decimal Price { get; set; }
        public override void AcceptVisitor(IVistor vistor)
        {
            vistor.Accept(this);
        }
    }

    public class RealState : Asset
    {
        public decimal Price { get; set; }
        public override void AcceptVisitor(IVistor vistor)
        {
            vistor.Accept(this);
        }
    }

    public class LoanCalculator : IVistor
    {
        float points = 0;
        public void Accept(RealState home)
        {
            points = home.Price > 1000 ? 2 : 3;
        }

        public void Accept(Car car)
        {
            points = car.Price > 500 ? 1 : 2;
        }

        public void Accept(BankAccount bankAccount)
        {
            points = bankAccount.Price > 100 ? 4 : 2;
        }

        public void Accept(Garage garage)
        {
            points = garage.Price > 600 ? 3 : 1;
        }
    }
}
