using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExceptionHandlingWeb.Code
{

    [Serializable]
    public class MyApplicationException : Exception
    {
        public MyApplicationException() { }
        public MyApplicationException(string message) : base(message) { }
        public MyApplicationException(string message, Exception inner) : base(message, inner) { }
        protected MyApplicationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}