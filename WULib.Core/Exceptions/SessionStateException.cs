using System;

namespace WULib.Core.Exceptions
{
    public class SessionStateException : Exception
    {
        public SessionStateException(string message) : base(message)
        {
        }
    }
}
