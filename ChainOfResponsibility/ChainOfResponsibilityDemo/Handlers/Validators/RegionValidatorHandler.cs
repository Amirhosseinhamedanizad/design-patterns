using ChainOfResponsibilityDemo.Handlers.Exceptions;
using ChainOfResponsibilityDemo.Models;

namespace ChainOfResponsibilityDemo.Handlers.Validators
{
    public class RegionValidatorHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if (RegionMustBeCanada(user))
            {
                throw new RegionValidationException("user must be from canada.");
            }
            base.Handle(user);
        }

        private bool RegionMustBeCanada(User user)
        {
            return !user.Region.Equals("CA");
        }
    }
}
