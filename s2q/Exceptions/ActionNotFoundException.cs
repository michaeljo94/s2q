using System;
using System.Runtime.Serialization;

namespace s2q.Exceptions
{
    public class ActionNotFoundException: Exception
    {
        public ActionNotFoundException()
        {
        }

        protected ActionNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public ActionNotFoundException(string? message) : base(message)
        {
        }

        public ActionNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}