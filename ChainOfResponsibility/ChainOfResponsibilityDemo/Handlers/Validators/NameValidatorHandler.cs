using ChainOfResponsibilityDemo.Handlers.Exceptions;
using ChainOfResponsibilityDemo.Models;

namespace ChainOfResponsibilityDemo.Handlers.Validators
{
    public class NameValidatorHandler: Handler<User>
    {
        public override void Handle(User user)
        {
            if(user.Name.Length <= 0)
            {
                throw new NameValidationException("name length doesn't match our policy");
            }
            base.Handle(user);
        }
    }
}
