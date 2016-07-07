using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogUtility.Tests
{
    [TestClass]
    public class UserIdenityTest
    {
        [TestMethod]
        public void VerifyUserIdenity()
        {

            bool isTheSameUSer = false;

            String thisUser = AppDomain.CurrentDomain.BaseDirectory;
            Logger.LogEvent(thisUser, "", "");
        
            String file = AppDomain.CurrentDomain.BaseDirectory + @"\" + Constants.logEventFileName;
            String logFile = System.IO.File.ReadAllText(file);

            if (logFile.Contains(thisUser))
            {
                isTheSameUSer = true;
            }

            Assert.AreEqual(isTheSameUSer, true);

        }
    }
}
