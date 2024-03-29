﻿using System;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOSFunctionalTests.Application_Areas.Customer.Tests
{
    [TestClass]
    public class Profile : UnitTestClassBase<Profile>
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
        public void UpdateUserProfile_Successfully()
        {
        }

        [TestMethod]
        [Ignore]
        public void ChangePassword_Successfully()
        {

        }

        [TestCleanup]
        [Ignore]
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
