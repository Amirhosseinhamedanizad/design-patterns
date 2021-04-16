using System;

namespace ChainOfResponsibilityDemo.Handlers.Exceptions
{
    class RegionValidationException : Exception
    {
        public RegionValidationException(string message) : base(message) { }
    }

}
