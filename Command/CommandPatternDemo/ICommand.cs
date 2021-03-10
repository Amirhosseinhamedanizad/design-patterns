using System;

namespace CommandPatternDemo
{
    public interface ICommand
    {
    }

    public class TransferCommand : ICommand
    {
        public string FromPerson { get; set; }
        public string ToPerson { get; set; }
        public decimal Amount { get; set; }
    }

    public class WithdrawCommand : ICommand
    {
        public string Person { get; set; }
        public decimal Amount { get; set; }
    }

    //This is not an acceptable command
    //public class FakeCommand
    //{
    //    public string FromPerson { get; set; }
    //    public string ToPerson { get; set; }
    //    public decimal Amount { get; set; }
    //}

    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Handle(TCommand command);
    }

    public class TransferCommandHandler : ICommandHandler<TransferCommand>
    {
        private IBankingRepository _repository;
        public TransferCommandHandler(IBankingRepository repository)
        {
            //definisve programming
            _repository = repository ?? throw new ArgumentNullException(nameof(IBankingRepository));
        }
        public void Handle(TransferCommand command)
        {
            _repository.Transfer(command.FromPerson, command.ToPerson, command.Amount);
        }
    }

    public class WithdrawCommandHandler : ICommandHandler<WithdrawCommand>
    {
        private IBankingRepository _repository;
        public WithdrawCommandHandler(IBankingRepository repository)
        {
            //definisve programming
            _repository = repository ?? throw new ArgumentNullException(nameof(IBankingRepository));
        }
        public void Handle(WithdrawCommand command)
        {
            _repository.Withdraw(command.Person, command.Amount);
        }
    }
}