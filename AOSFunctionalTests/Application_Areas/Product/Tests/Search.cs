using System;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOSFunctionalTests.Application_Areas.Product.Tests
{
    [TestClass]
    public class Search : UnitTestClassBase<Search>
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
        public void SearchForProductByName_Successfully()
        {

        }

        [TestMethod]
        [Ignore]
        public void SearchForProductByInvalidKeyword_Failure()
        {

        }

        [TestMethod]
        [Ignore]
        public void SearchWithEmptyKeyword_Failure()
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
