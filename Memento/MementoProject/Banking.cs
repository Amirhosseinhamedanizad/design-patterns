using System.Collections.Generic;

namespace MementoProject
{
    //Originator
    public class Banking
    {
        private string _name;
        private string _amount;

        public StateList Stack = new StateList();

        public string Name
        {
            get { return _name;  }
            set { _name = value;  }
        }

        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public MementoState SaveMemento()
        {
            var savedState = new MementoState(_name, _amount);
            Stack.AddState(savedState);
            return savedState;
        }

        public void ResotreMemnto()
        {
            var lastState = Stack.GetState();
            Name = lastState.Name;
            Amount = lastState.Amount;
        }
    }

    //Memento
    public class MementoState
    {
        public string Name { get; set; }
        public string Amount { get; set; }
        public MementoState(string name, string amount)
        {
            Name = name;
            Amount = amount;
        }
    }

    //CareTaker
    public class StateList
    {
        Stack<MementoState> _stack = new Stack<MementoState>();

        public void AddState(MementoState state)
        {
            _stack.Push(state);
        }

        public MementoState GetState()
        {
            return _stack.Pop();
        }
    }
}
