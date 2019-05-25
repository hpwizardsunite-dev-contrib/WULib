using System;

namespace WULib.Core.Exceptions
{
    public class WrongCredentialsException : Exception
    {

        public WrongCredentialsException(string message) : base(message)
        {

        }
    }
}
