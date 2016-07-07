using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogUtility
{
    public class Logger
    {
        private static String currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private Logger()
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user">The User name</param>
        /// <param name="exc">The exception object</param>
        /// <param name="methodName">The method name that call the logger</param>
        public static void LogException(string user, Exception exc, string methodName)
        {

            String logFile = currentDirectory + @"\" + Constants.logExceptionFileName;

            StreamWriter sw = new StreamWriter(logFile, true);
            sw.WriteLine("********** {0} **********", DateTime.Now);
            if (exc.InnerException != null)
            {
                sw.Write("Inner Exception Type: ");
                sw.WriteLine(exc.InnerException.GetType().ToString());
                sw.Write("Inner Exception: ");
                sw.WriteLine(exc.InnerException.Message);
                sw.Write("Inner Source: ");
                sw.WriteLine(exc.InnerException.Source);
                if (exc.InnerException.StackTrace != null)
                {
                    sw.WriteLine("Inner Stack Trace: ");
                    sw.WriteLine(exc.InnerException.StackTrace);
                }
            }
            sw.Write("Exception Type: ");
            sw.WriteLine(exc.GetType().ToString());
            sw.WriteLine("Exception: " + exc.Message);
            sw.Write("User: ");
            sw.Write(user);
            sw.Write(" ");
            sw.Write("Method Name: ");
            sw.WriteLine(methodName);
            sw.WriteLine("Stack Trace: ");
            if (exc.StackTrace != null)
            {
                sw.WriteLine(exc.StackTrace);
                sw.WriteLine();
            }
            sw.Close();
        }
        /// <summary>
        /// Log Event Method
        /// </summary>
        /// <param name="user">The User name</param>
        /// <param name="methodName">The method name that call the logger</param>
        /// <param name="description">A brief event description</param>
        public static void LogEvent(string user, string methodName, string description)
        {
            

            String logFile = currentDirectory + @"\" + Constants.logEventFileName;

            StreamWriter sw = new StreamWriter(logFile, true);
            sw.WriteLine("********** {0} **********", DateTime.Now);
            sw.Write("User: ");
            sw.Write(user);
            sw.Write(" ");
            sw.Write("Method Name: ");
            sw.WriteLine(methodName);
            sw.WriteLine("Descriction: " + description);
            sw.WriteLine();

            sw.Close();
        }
    }
}
