using System;

namespace ChainOfResponsibilityDemo.Handlers.Exceptions
{
    public class NameValidationException: Exception
    {
        public NameValidationException(string message): base(message) { }
    }
}
