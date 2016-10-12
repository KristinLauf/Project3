using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExceptionHandlingWeb.Code
{
    public class OutputWindowLogMedia : LogMedia
    {
        public override void LogMessage(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}