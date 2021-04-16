using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDemo.Handlers.Exceptions
{
    public class SocialSecurityException : Exception
    {
        public SocialSecurityException(string message) : base(message) { }
    }
}
