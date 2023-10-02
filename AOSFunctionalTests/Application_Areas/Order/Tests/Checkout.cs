using System;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOSFunctionalTests.Application_Areas.Order.Tests
{
    [TestClass]
    public class Checkout : UnitTestClassBase<Checkout>
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
        public void PlaceOrderWithValidData_Successfully()
        {
        }

        [TestMethod]
        [Ignore]
        public void PlaceOrderWithInvalidShippingAddress_Failure()
        {

        }

        [TestMethod]
        [Ignore]
        public void ApplyCouponCode_Successfully()
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
