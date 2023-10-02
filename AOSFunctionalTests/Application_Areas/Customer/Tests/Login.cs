using System;
using System.Diagnostics;
using HP.LFT.SDK;
using HP.LFT.SDK.Web;
using HP.LFT.Verifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HP.LFT.SDK.TE;
using System.Timers;
using System.Threading;

namespace AOSFunctionalTests.Application_Areas.Customer.Tests
{
    [TestClass]
    public class Login : UnitTestClassBase<Login>
    {
        public TestContext TestContext { get; set; }
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
        public void LoginWithValidCredentials_Successfully()
        {

        }

        [TestMethod]
        [Ignore]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"|DataDirectory|\Data\customer.csv", "customer#csv", DataAccessMethod.Sequential)]
        public void LoginWithInvalidCredentials_Failure()
        {

            IBrowser browser = BrowserFactory.Launch(BrowserType.Chrome);
            browser.Navigate("http://advantageonlineshopping.com/#/");
            


            //Debug.WriteLine("First Name: " + TestContext.DataRow["firstname"].ToString());
            //Debug.WriteLine("Last Name: " + TestContext.DataRow["lastname"].ToString());
            //Debug.WriteLine("Email: " + TestContext.DataRow["email"].ToString());
            //Debug.WriteLine("Profession: " + TestContext.DataRow["profession"].ToString());
            //Debug.WriteLine("Password: " + TestContext.DataRow["password"].ToString());

            //var password = TestContext.DataRow["password"].ToString();
            //var email = TestContext.DataRow["email"].ToString();
            var password = "1234512";
            var email = "mail@mail.com";




            var userMenuLink = browser.Describe<ILink>(new LinkDescription
            {
                InnerText = @"My account My orders Sign out ",
                TagName = @"A"
            });
            userMenuLink.Click();

            var usernameEditField = browser.Describe<IEditField>(new EditFieldDescription
            {
                Name = @"username",
                TagName = @"INPUT",
                Type = @"text"
            });
            usernameEditField.SetValue(email);

            var passwordWebElement = browser.Describe<IWebElement>(new WebElementDescription
            {
                InnerText = @"Password",
                TagName = @"LABEL"
            });
            passwordWebElement.Click();

            var passwordEditField = browser.Describe<IEditField>(new EditFieldDescription
            {
                Name = @"password",
                TagName = @"INPUT",
                Type = @"password"
            });
            passwordEditField.SetValue(password);

            var signInBtnButton = browser.Describe<IButton>(new ButtonDescription
            {
                ButtonType = @"button",
                Name = @"SIGN IN",
                TagName = @"BUTTON"
            });
            signInBtnButton.Click();

            var signInResultMessageWebElement = browser.Describe<IWebElement>(new WebElementDescription
            {
                TagName = @"LABEL",
                InnerText = @"Incorrect user name or password."
            });
            HP.LFT.Report.Reporter.StartReportingContext("Validate the properties of signInResultMessage", HP.LFT.Report.ReportContextInfo.VerificationMode());
            Verify.IsTrue(signInResultMessageWebElement.Exists(), "Verification", "Verify property: isVisible");
            HP.LFT.Report.Reporter.EndReportingContext();
            System.Threading.Thread.Sleep(4000);

            browser.Close();









        }

        [TestMethod]
        
        public void MyLoginTest()
        {
            IBrowser browser = BrowserFactory.Launch(BrowserType.Chrome);
            browser.Navigate("http://advantageonlineshopping.com/#/");


            var userMenuLink = browser.Describe<ILink>(new LinkDescription
            {
                InnerText = @"My account My orders Sign out ",
                TagName = @"A"
            });
            userMenuLink.Click();
            

            var usernameEditField = browser.Describe<IEditField>(new EditFieldDescription
            {
                Name = @"username",
                TagName = @"INPUT",
                Type = @"text"
            });
            usernameEditField.SetValue("RandomUserName");

            var passwordEditField = browser.Describe<IEditField>(new EditFieldDescription
            {
                Name = @"password",
                TagName = @"INPUT",
                Type = @"password"
            });
            passwordEditField.SetSecure("6514481c7a0efe6e7834029e51d2341af2856953ce0d6971a80d6aec61a3a4fe59ff");

            var signInBtnButton = browser.Describe<IButton>(new ButtonDescription
            {
                ButtonType = @"button",
                Name = @"SIGN IN",
                TagName = @"BUTTON"
            });
            signInBtnButton.Click();

            signInBtnButton.Click();

            var signInResultMessageWebElement = browser.Describe<IWebElement>(new WebElementDescription
            {
                TagName = @"LABEL",
                InnerText = @"Incorrect user name or password."
            });
            
            Verify.AreEqual(@"Incorrect user name or password.", signInResultMessageWebElement.InnerText, "Verification", "Verify property: innerText");


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
