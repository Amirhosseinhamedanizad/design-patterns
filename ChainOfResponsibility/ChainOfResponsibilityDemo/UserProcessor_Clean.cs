using ChainOfResponsibilityDemo.Handlers.Validators;
using ChainOfResponsibilityDemo.Models;
using System;

namespace ChainOfResponsibilityDemo
{
    public class UserProcessor_Clean
    {
        public void Register(User user)
        {
            try
            {
                var handler = new NameValidatorHandler();

                handler.SetNext(new RegionValidatorHandler())
                    .SetNext(new RegionValidatorHandler())
                    .SetNext(new SocialSecurityValidatorHandler())
                    .SetNext(new AgeValidatorHandler());

                handler.Handle(user);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
