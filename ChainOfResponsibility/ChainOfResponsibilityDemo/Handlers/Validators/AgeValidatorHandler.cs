using ChainOfResponsibilityDemo.Handlers.Exceptions;
using ChainOfResponsibilityDemo.Models;

namespace ChainOfResponsibilityDemo.Handlers.Validators
{
    public class AgeValidatorHandler: Handler<User>
    {
        public override void Handle(User request)
        {
            if(request.Age < 18)
            {
                throw new AgeValidationException("your age is below than 18 years old");
            }

            base.Handle(request);
        }
    }
}
