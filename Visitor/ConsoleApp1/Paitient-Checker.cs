using System;

namespace Console1
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    public interface IVisitor
    {
        void Visit(IElement element);
    }

    public class HIVPaiteint : IElement
    {
        public string Name { get; set; }

        public HIVPaiteint(string name)
        {
            Name = name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this); //double dispatching
        }
    }

    public class HepatitPaiteint : IElement
    {
        public string Name { get; set; }

        public HepatitPaiteint(string name)
        {
            Name = name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class CheckupOperator : IVisitor
    {
        public void Visit(IElement element)
        {
            HIVPaiteint paitient = (HIVPaiteint)element;
            Console.WriteLine($"paiteint with name of {paitient.Name} has been checked up.");
        }
    }
}
