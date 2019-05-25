using System;

namespace WULib.Core.Exceptions
{
    public class GoogleLoginException : Exception
    {
        public GoogleLoginException(string message) : base(message)
        {
        }
    }
}
