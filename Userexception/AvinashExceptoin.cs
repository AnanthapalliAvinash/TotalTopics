using System;
using System.Runtime.Serialization;

namespace AvinashException
{
    [Serializable]
    internal class AvinashExceptoin : Exception
    {
        public AvinashExceptoin()
        {
        }

        public AvinashExceptoin(string message) : base(message)
        {
        }

        public AvinashExceptoin(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AvinashExceptoin(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}