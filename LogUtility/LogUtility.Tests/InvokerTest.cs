using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogUtility.Tests
{
    [TestClass]
    public class InvokerTest
    {
        [TestMethod]
        public void InvokerEvent()
        {
            bool isInvokerEvent = true;
             
            try
            {
                Logger.LogEvent("x", "y", "z");
            }
            catch (Exception ex)
            {
                isInvokerEvent = false;
                Logger.LogException("x", ex, "");
            }

            Assert.AreEqual(isInvokerEvent, true);


        }
        [TestMethod]
        public void InvokerException()
        {
            bool isInvokerException = false;

            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                isInvokerException = true;
                Logger.LogException("x", ex, "");
            }

            Assert.AreEqual(isInvokerException, true);


        }
        [TestMethod]
        public void InvokerInnerException()
        {
            bool isInvokerException = false;

            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {

                if (ex.InnerException == null)
                {
                    isInvokerException = true;
                    Logger.LogException("x", ex, "");
                }
                else
                {

                }

            }

            Assert.AreEqual(isInvokerException, true);


        }

    }
}
