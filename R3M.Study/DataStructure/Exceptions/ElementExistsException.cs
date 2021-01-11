using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DataStructure.Exceptions
{
    public class ElementExistsException : Exception
    {
        public ElementExistsException()
        {
        }

        public ElementExistsException(string message) : base(message)
        {
        }

        public ElementExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ElementExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
