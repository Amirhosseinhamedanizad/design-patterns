using ChainOfResponsibilityDemo.Handlers.Exceptions;
using ChainOfResponsibilityDemo.Models;
using System;

namespace ChainOfResponsibilityDemo.Handlers.Validators
{
    //Single reponsibility pattern
    public class SocialSecurityValidatorHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if (CheckSSNIsNotEmpty(user) || CheckIfSSNDoesHaveDashBetweenNumbers(user))
            {
                throw new SocialSecurityException("SSN number doesn't match our policy and include invalid characters");
            }
            base.Handle(user);
        }

        private bool CheckSSNIsNotEmpty(User user)
        {
            return String.IsNullOrEmpty(user.SSN);
        }

        private bool CheckIfSSNDoesHaveDashBetweenNumbers(User user)
        {
            return !user.SSN.Contains("-");
        }
    }
}
