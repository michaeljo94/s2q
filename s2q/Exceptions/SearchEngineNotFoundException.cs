using System;
using System.Runtime.Serialization;

namespace s2q.Exceptions
{
    public class SearchEngineNotFoundException : Exception
    {
        public SearchEngineNotFoundException()
        {
        }


        protected SearchEngineNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public SearchEngineNotFoundException(string? message) : base(message)
        {
        }

        public SearchEngineNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}