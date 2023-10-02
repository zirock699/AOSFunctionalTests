using System;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOSFunctionalTests.Application_Areas.Product.Tests
{
    [TestClass]
    public class Cart : UnitTestClassBase<Cart>
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            GlobalSetup(context);
        }

        [TestInitialize]
        [Ignore]
        public void TestInitialize()
        {
        }

        [TestMethod]
        [Ignore]
        public void AddProductToCart_Successfully()
        { 
        }

        [TestMethod]
        [Ignore]
        public void RemoveProductFromCart_Successfully()
        {

        }
        [TestMethod]
        [Ignore]
        public void UpdateQuantityInCart_Successfully()
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
