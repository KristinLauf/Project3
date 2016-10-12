using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExceptionHandlingWeb.Code
{
    public class Logger
    {
        public Logger()
        { 
            m_loggers.Add(new OutputWindowLogMedia());
            m_loggers.Add(new TextFileLogMedia());
            m_loggers.Add(new EmailLogMedia());
        }
        public List<LogMedia> m_loggers = new List<LogMedia>();


        public void LogException(Exception ex)
        {
            
            string message = ex.Message + DateTime.Now; // make message from ex and datetime.now


            foreach (var item in m_loggers)
            {
                item.LogMessage(message);
            }
        }

    }
}