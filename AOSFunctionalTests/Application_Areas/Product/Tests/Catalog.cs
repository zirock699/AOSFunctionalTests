﻿using System;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOSFunctionalTests.Application_Areas.Product.Tests
{
    [TestClass]
    public class Catalog : UnitTestClassBase<Catalog>
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
        public void ViewProductDetails_Successfully()
        {

        }

        [TestMethod]
        [Ignore]
        public void FilterProductsByCategory_Successfully()
        {

        }

        [TestMethod]
        [Ignore]
        public void SortProductsByPrice_Successfully()
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
