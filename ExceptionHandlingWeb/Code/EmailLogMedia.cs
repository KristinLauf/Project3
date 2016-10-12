using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Net.Mail;

namespace ExceptionHandlingWeb.Code
{
    public class EmailLogMedia : LogMedia
    {
        public override void LogMessage(string msg)
        {
            string strEmail = ConfigurationManager.AppSettings["Email"];

                using (MailMessage message = new MailMessage())
                {
                    // See above, email address should
                    // be read from appSettings:
                    message.To.Add(strEmail);
                    message.Subject = "Error email message";
                    message.Body = msg; //message inn
                    using (SmtpClient client = new SmtpClient())
                    {
                        client.EnableSsl = true; // Not always necessary
                        client.Send(message);
                    }
                }
            }
    }
}