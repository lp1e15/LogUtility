using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            String methodName = "Main";

            Logger.LogEvent(userName, methodName, methodName + " has been initialized");

            for (int i = 0; i < 10; i++)
            {
                String eventName = "For loop";
                System.Console.WriteLine(i);
                try
                {
                    if (i == 9) throw new Exception();
                }
                catch (Exception ex)
                {
                    Logger.LogException(userName, ex, eventName);
                }
                
                Logger.LogEvent(userName, methodName, "The value of 'i' is: " + i);


            }


            Logger.LogEvent(userName, methodName, methodName + " has been terminated" );
        }
    }
}
