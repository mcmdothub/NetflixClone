using System;

namespace DotnetFlix.Objects.Exceptions
{
    public class TMDbException : Exception
    {
        public TMDbException(string message)
                : base(message)
        {
        }
    }
}