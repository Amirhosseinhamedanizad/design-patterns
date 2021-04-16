using System;

namespace ChainOfResponsibilityDemo.Handlers.Exceptions
{
    public class AgeValidationException : Exception
    {
        public AgeValidationException(string message) : base(message) { }
    }

}
