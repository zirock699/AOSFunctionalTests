using System;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOSFunctionalTests.Application_Areas.Order.Tests
{
    [TestClass]
    public class Payment : UnitTestClassBase<Payment>
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            GlobalSetup(context);
        }

        [TestInitialize]
        public void TestInitialize()
        {
        }

        [TestMethod]
        [Ignore]
        public void MakePaymentWithValidCreditCard_Successfully()
        {
        }

        [TestMethod]
        [Ignore]
        public void MakePaymentWithInvalidCreditCard_Failure()
        {

        }

      

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            GlobalTearDown();
        }
    }
}
