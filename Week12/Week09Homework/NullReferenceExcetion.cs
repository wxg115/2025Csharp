using System;
using System.Runtime.Serialization;

namespace Week09Homework
{
    [Serializable]
    internal class NullReferenceExcetion : Exception
    {
        public NullReferenceExcetion()
        {
        }

        public NullReferenceExcetion(string message) : base(message)
        {
        }

        public NullReferenceExcetion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NullReferenceExcetion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}