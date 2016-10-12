using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ExceptionHandlingWeb.Code
{
    public class TextFileLogMedia : LogMedia
    {
        public override void LogMessage(string message)
        {
            /*
            string temp = Path.GetTempPath(); 
            Console.WriteLine(temp);

            string random = Path.GetRandomFileName();
            Console.WriteLine(random);

            string both = Path.Combine(temp, random);
            Console.WriteLine(both);*/

            StreamWriter writer = new StreamWriter(Path.GetTempPath() + "kristinh12_logfile.txt", true);
            writer.WriteLine(message);
            writer.Close();
        }
    }
}