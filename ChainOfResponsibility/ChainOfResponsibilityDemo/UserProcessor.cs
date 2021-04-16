using ChainOfResponsibilityDemo.Models;
using System;

namespace ChainOfResponsibilityDemo
{
    public class UserProcessor
    {
        //if you assign another responsibility which is validations => Violate SSP
        //OCP (Open closed principle) => open extensibility / not for modification
        //hard to debug | violate OCP | hard to understand
        public bool Register(User user)
        {
            if(user.Name.Length <= 0)
            {
                return false;
            } else if(user.Region != "CA")
            {
                return false;
            } else if(String.IsNullOrEmpty(user.SSN) || user.SSN.Contains("-"))
            {
                return false;
            } else if (user.Age < 18)
            {
                return false;
            }
            return true;
        }
    }
}
