using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogUtility.Clients
{
    public class AClass
    {
        private AClass() { }

        private String aField = String.Empty;

        public static bool AMethod()
        {
            String methodName = "AMethod";

            Logger.LogEvent("Anonimous", methodName, methodName + " has been initialized");

            bool value = true;

            Logger.LogEvent("Anonimous", methodName, methodName + " has been terminated");

            return value;
            
        }
    }
}
