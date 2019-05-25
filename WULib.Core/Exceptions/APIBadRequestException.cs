using System;

namespace WULib.Core.Exceptions
{
    public class APIBadRequestException : Exception
    {
        public APIBadRequestException()
        {
        }

        public APIBadRequestException(string message) : base(message)
        {
        }

        public APIBadRequestException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
