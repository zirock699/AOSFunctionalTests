using System;
using System.Diagnostics;
using HP.LFT.SDK;
using HP.LFT.SDK.Web;
using HP.LFT.Verifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AOSFunctionalTests.Application_Areas.Customer.Tests
{
    [TestClass]
    public class Registration : UnitTestClassBase<Registration>
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

        //[TestMethod]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"..\..\..\AOSFunctionalTests\Data_Sources\RegisterCustomer.csv", "RegisterCustomer#csv", DataAccessMethod.Sequential), DeploymentItem("RegisterCustomer.csv")]
        //public void RegisterNewCustomer_Successfully()
        //{
        //    IBrowser browser = BrowserFactory.Launch(BrowserType.Chrome);
        //    browser.Navigate("http://advantageonlineshopping.com/#/register");

        //    var email = $"{Guid.NewGuid().ToString().Substring(0, 8)}@example.com";
        //    var userName = email.Split('@')[0];
        //    var password = TestContext.DataRow["password"].ToString();
        //    var repeatPassword = TestContext.DataRow["password"].ToString();
        //    var firstName = TestContext.DataRow["firstName"].ToString();
        //    var lastName = TestContext.DataRow["lastName"].ToString();
        //    var phoneNumber = TestContext.DataRow["phoneNumber"].ToString();
        //    var country = TestContext.DataRow["country"].ToString();
        //    var state = TestContext.DataRow["state"].ToString();
        //    var address = TestContext.DataRow["address"].ToString();
        //    var postCode = TestContext.DataRow["postCode"].ToString();

        //    var usernameRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"usernameRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    usernameRegisterPageEditField.SetValue(userName);

        //    var emailRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"emailRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });

        //    emailRegisterPageEditField.SetValue(email);

        //    var passwordRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"passwordRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"password"
        //    });
        //    passwordRegisterPageEditField.SetValue(password);

        //    var confirmPasswordRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"confirm_passwordRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"password"
        //    });
        //    confirmPasswordRegisterPageEditField.SetValue(repeatPassword);

        //    var firstNameRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"first_nameRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    firstNameRegisterPageEditField.SetValue(firstName);

        //    var lastNameRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"last_nameRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    lastNameRegisterPageEditField.SetValue(lastName);

        //    var phoneNumberRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"phone_numberRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    phoneNumberRegisterPageEditField.SetValue(phoneNumber);

        //    var countryListboxRegisterPageListBox = browser.Describe<IListBox>(new ListBoxDescription
        //    {
        //        Name = @"countryListboxRegisterPage",
        //        TagName = @"SELECT"
        //    });
        //    countryListboxRegisterPageListBox.Select(country);

        //    var cityRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"cityRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    cityRegisterPageEditField.SetValue(state);

        //    var addressRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"addressRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    addressRegisterPageEditField.SetValue(address);

        //    var stateProvinceRegionWebElement = browser.Describe<IWebElement>(new WebElementDescription
        //    {
        //        InnerText = @"State / Province / Region",
        //        TagName = @"LABEL"
        //    });
        //    stateProvinceRegionWebElement.Click();

        //    var stateProvinceRegionRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"state_/_province_/_regionRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    stateProvinceRegionRegisterPageEditField.SetValue(state);

        //    var postalCodeRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"postal_codeRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    postalCodeRegisterPageEditField.SetValue(postCode);

        //    var iAgreeCheckBox = browser.Describe<ICheckBox>(new CheckBoxDescription
        //    {
        //        Name = @"i_agree",
        //        TagName = @"INPUT",
        //        Type = @"checkbox"
        //    });
        //    iAgreeCheckBox.Set(true);

        //    var registerBtnundefinedButton = browser.Describe<IButton>(new ButtonDescription
        //    {
        //        ButtonType = @"button",
        //        Name = @"REGISTER",
        //        TagName = @"BUTTON"
        //    });
        //    registerBtnundefinedButton.Click();

        //    browser.CloseAllTabs();

        //}

        //[TestMethod]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"..\..\..\AOSFunctionalTests\Data_Sources\RegisterCustomer.csv", "RegisterCustomer#csv", DataAccessMethod.Sequential), DeploymentItem("RegisterCustomer.csv")]

        //public void AttemptRegistrationWithInvalidEmail_Success()
        //{
        //    IBrowser browser = BrowserFactory.Launch(BrowserType.Chrome);
        //    browser.Navigate("http://advantageonlineshopping.com/#/register");
        //    Debug.WriteLine(TestContext.DataRow["invalidEmail"].ToString());
        //    string invalidEmail = TestContext.DataRow["invalidEmail"].ToString();
        //    var userName = TestContext.DataRow["userName"].ToString();
        //    var password = TestContext.DataRow["password"].ToString();
        //    var repeatPassword = TestContext.DataRow["password"].ToString();
        //    var firstName = TestContext.DataRow["firstName"].ToString();
        //    var lastName = TestContext.DataRow["lastName"].ToString();
        //    var phoneNumber = TestContext.DataRow["phoneNumber"].ToString();
        //    var country = TestContext.DataRow["country"].ToString();
        //    var state = TestContext.DataRow["state"].ToString();
        //    var address = TestContext.DataRow["address"].ToString();
        //    var postCode = TestContext.DataRow["postCode"].ToString();

        //    var usernameRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"usernameRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    usernameRegisterPageEditField.SetValue(userName);

        //    var emailRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"emailRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    emailRegisterPageEditField.SetValue(invalidEmail);


        //    var usernameUsernameUse5CharacterOrLongerUseMaximum15CWebElement = browser.Describe<IWebElement>(new WebElementDescription
        //    {
        //        InnerText = @"*UsernameUsername- Use 5 character or longer - Use maximum 15 character ",
        //        TagName = @"SEC-VIEW"
        //    });
        //    usernameUsernameUse5CharacterOrLongerUseMaximum15CWebElement.Click();


        //    var passwordRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"passwordRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"password"
        //    });
        //    passwordRegisterPageEditField.SetValue(password);

        //    var confirmPasswordRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"confirm_passwordRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"password"
        //    });
        //    confirmPasswordRegisterPageEditField.SetValue(repeatPassword);

        //    var firstNameRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"first_nameRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    firstNameRegisterPageEditField.SetValue(firstName);

        //    var lastNameRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"last_nameRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    lastNameRegisterPageEditField.SetValue(lastName);

        //    var phoneNumberRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"phone_numberRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    phoneNumberRegisterPageEditField.SetValue(phoneNumber);

        //    var countryListboxRegisterPageListBox = browser.Describe<IListBox>(new ListBoxDescription
        //    {
        //        Name = @"countryListboxRegisterPage",
        //        TagName = @"SELECT"
        //    });
        //    countryListboxRegisterPageListBox.Select(country);

        //    var cityRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"cityRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    cityRegisterPageEditField.SetValue(state);

        //    var addressRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"addressRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    addressRegisterPageEditField.SetValue(address);

        //    var stateProvinceRegionWebElement = browser.Describe<IWebElement>(new WebElementDescription
        //    {
        //        InnerText = @"State / Province / Region",
        //        TagName = @"LABEL"
        //    });
        //    stateProvinceRegionWebElement.Click();

        //    var stateProvinceRegionRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"state_/_province_/_regionRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    stateProvinceRegionRegisterPageEditField.SetValue(state);

        //    var postalCodeRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"postal_codeRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    postalCodeRegisterPageEditField.SetValue(postCode);

        //    var iAgreeCheckBox = browser.Describe<ICheckBox>(new CheckBoxDescription
        //    {
        //        Name = @"i_agree",
        //        TagName = @"INPUT",
        //        Type = @"checkbox"
        //    });
        //    iAgreeCheckBox.Set(true);


        //    var yourEmailAddressIsnTFormattedCorrectlyWebElement = browser.Describe<IWebElement>(new WebElementDescription
        //    {
        //        InnerText = @"Your email address isn't formatted correctly",
        //        TagName = @"LABEL"
        //    });

        //    Verify.IsTrue(yourEmailAddressIsnTFormattedCorrectlyWebElement.IsVisible);
        //    browser.CloseAllTabs();

        //}

        //[TestMethod]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"..\..\..\AOSFunctionalTests\Data_Sources\RegisterCustomer.csv", "RegisterCustomer#csv", DataAccessMethod.Sequential), DeploymentItem("RegisterCustomer.csv")]
        //public void AttemptRegistrationWithExistingUserName_Failure()
        //{
        //    IBrowser browser = BrowserFactory.Launch(BrowserType.Chrome);
        //    browser.Navigate("http://advantageonlineshopping.com/#/register");


        //    string email = TestContext.DataRow["email"].ToString();
        //    var userName = TestContext.DataRow["userName"].ToString();
        //    var password = TestContext.DataRow["password"].ToString();
        //    var repeatPassword = TestContext.DataRow["password"].ToString();
        //    var firstName = TestContext.DataRow["firstName"].ToString();
        //    var lastName = TestContext.DataRow["lastName"].ToString();
        //    var phoneNumber = TestContext.DataRow["phoneNumber"].ToString();
        //    var country = TestContext.DataRow["country"].ToString();
        //    var state = TestContext.DataRow["state"].ToString();
        //    var address = TestContext.DataRow["address"].ToString();
        //    var postCode = TestContext.DataRow["postCode"].ToString();


        //    var usernameRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"usernameRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    usernameRegisterPageEditField.SetValue(userName);

        //    var emailRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"emailRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });

        //    emailRegisterPageEditField.SetValue(email);

        //    var passwordRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"passwordRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"password"
        //    });
        //    passwordRegisterPageEditField.SetValue(password);

        //    var confirmPasswordRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"confirm_passwordRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"password"
        //    });
        //    confirmPasswordRegisterPageEditField.SetValue(repeatPassword);

        //    var firstNameRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"first_nameRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    firstNameRegisterPageEditField.SetValue(firstName);

        //    var lastNameRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"last_nameRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    lastNameRegisterPageEditField.SetValue(lastName);

        //    var phoneNumberRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"phone_numberRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    phoneNumberRegisterPageEditField.SetValue(phoneNumber);

        //    var countryListboxRegisterPageListBox = browser.Describe<IListBox>(new ListBoxDescription
        //    {
        //        Name = @"countryListboxRegisterPage",
        //        TagName = @"SELECT"
        //    });
        //    countryListboxRegisterPageListBox.Select(country);

        //    var cityRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"cityRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    cityRegisterPageEditField.SetValue(state);

        //    var addressRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"addressRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    addressRegisterPageEditField.SetValue(address);

        //    var stateProvinceRegionWebElement = browser.Describe<IWebElement>(new WebElementDescription
        //    {
        //        InnerText = @"State / Province / Region",
        //        TagName = @"LABEL"
        //    });
        //    stateProvinceRegionWebElement.Click();

        //    var stateProvinceRegionRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"state_/_province_/_regionRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    stateProvinceRegionRegisterPageEditField.SetValue(state);

        //    var postalCodeRegisterPageEditField = browser.Describe<IEditField>(new EditFieldDescription
        //    {
        //        Name = @"postal_codeRegisterPage",
        //        TagName = @"INPUT",
        //        Type = @"text"
        //    });
        //    postalCodeRegisterPageEditField.SetValue(postCode);

        //    var iAgreeCheckBox = browser.Describe<ICheckBox>(new CheckBoxDescription
        //    {
        //        Name = @"i_agree",
        //        TagName = @"INPUT",
        //        Type = @"checkbox"
        //    });
        //    iAgreeCheckBox.Set(true);


        //    var registerBtnundefinedButton = browser.Describe<IButton>(new ButtonDescription
        //    {
        //        ButtonType = @"button",
        //        Name = @"REGISTER",
        //        TagName = @"BUTTON"
        //    });
        //    registerBtnundefinedButton.Click();

        //    var userNameAlreadyExistsWebElement = browser.Describe<IWebElement>(new WebElementDescription
        //    {
        //        TagName = @"LABEL",
        //        InnerText = @"User name already exists "
        //    });
        //    Verify.IsTrue(userNameAlreadyExistsWebElement.IsVisible, "Verification", "Verify property: isVisible");

        //    browser.CloseAllTabs();
        //}

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
