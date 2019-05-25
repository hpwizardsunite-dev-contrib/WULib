﻿using System;

namespace WULib.Core.Exceptions
{
    public class InvalidPlatformException : Exception
    {
        public InvalidPlatformException()
        {
        }

        public InvalidPlatformException(string message) : base(message)
        {
        }

        public InvalidPlatformException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
