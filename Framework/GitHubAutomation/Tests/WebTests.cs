using NUnit.Framework;
using GitHubAutomation.Pages;
using GitHubAutomation.Services;


namespace GitHubAutomation.Tests
{
    [TestFixture]
    public class WebTests : GeneralConfig
    {
        [Test]
        public void PurchaseToy_EnterEmptyName_EmptyFieldErrorAppears()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string emptyFieldErrorText = "Заполните это поле";
                var mainPage = new MainPage(Driver);
                var toyInfoPage = new ToyInfoPage(Driver);

                mainPage.SelectToyClick();
                toyInfoPage.PurchaseToyClick();
                toyInfoPage.SendOrderClick();

                Assert.AreEqual(emptyFieldErrorText, toyInfoPage.GetNameErrorText());
            });
        }

        [Test]
        public void Register_EnterThreeSymbolsInPasswordField_PasswordLengthErrorAppears()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string passwordErrorText = "Минимум 6 символов";
                var mainPage = new MainPage(Driver);
                var registerPage = new RegisterPage(Driver);

                mainPage.LoginClick();
                mainPage.RegisterClick();
                registerPage.EnterPassword(TestDataReader.GetTestData("Password"));
                registerPage.RegisterClick();

                Assert.AreEqual(passwordErrorText, registerPage.GetPasswordError());
            });
        }

        [Test]
        public void Register_EnterInvalidMail_InvalidEmailErrorAppears()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string emailErrorText = "Неверный формат";
                var mainPage = new MainPage(Driver);
                var registerPage = new RegisterPage(Driver);

                mainPage.LoginClick();
                mainPage.RegisterClick();
                registerPage.EnterEmail(TestDataReader.GetTestData("Email"));
                registerPage.RegisterClick();

                Assert.AreEqual(emailErrorText, registerPage.GetEmailError());
            });
        }

        [Test]
        public void Register_EnterDifferentPasswords_NotMatchingPasswordsErrorAppears()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string CpasswordErrorText = "Пароли не совпадают";
                var mainPage = new MainPage(Driver);
                var registerPage = new RegisterPage(Driver);

                mainPage.LoginClick();
                mainPage.RegisterClick();
                registerPage.EnterPassword(TestDataReader.GetTestData("Password"));
                registerPage.EnterCPassword(TestDataReader.GetTestData("Password2"));
                registerPage.RegisterClick();

                Assert.AreEqual(CpasswordErrorText, registerPage.GetConfirmPasswordError());
            });
        }

        [Test]
        public void Login_EnterWrongCredentials_WrongCredentialsErrorAppears()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                var mainPage = new MainPage(Driver);
                var registerPage = new RegisterPage(Driver);

                mainPage.LoginClick();
                mainPage.EnterPassword(TestDataReader.GetTestData("Password"));
                mainPage.EnterPassword(TestDataReader.GetTestData("Password"));
                mainPage.EnterLogin(TestDataReader.GetTestData("email"));
                mainPage.Login2Click();
                Assert.IsTrue(mainPage.GetWrongCredentialsError());
            });
        }

        [Test]
        public void Login_EnterThreeSymbolsInPasswordField_PasswordLengthErrorAppears()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string passwordErrorText = "Минимум 6 символов";
                var mainPage = new MainPage(Driver);
                var registerPage = new RegisterPage(Driver);

                mainPage.LoginClick();
                mainPage.EnterPassword(TestDataReader.GetTestData("Password"));
                mainPage.Login2Click();

                Assert.AreEqual(passwordErrorText, mainPage.GetPasswordError());
            });
        }

        [Test]
        public void PurchaseToy_EnterInvalidMail_InvalidEmailErrorAppears()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string emailErrorText = "Неверный формат";
                var mainPage = new MainPage(Driver);
                var toyInfoPage = new ToyInfoPage(Driver);

                mainPage.SelectToyClick();
                toyInfoPage.PurchaseToyClick();
                toyInfoPage.EnterEmail(TestDataReader.GetTestData("Email"));
                toyInfoPage.SendOrderClick();

                Assert.AreEqual(emailErrorText, toyInfoPage.GetEmailError());
            });
        }

        [Test]
        public void PurchaseToy_EnterEmptyNameInChipForms_EmptyFieldErrorAppears()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string emptyFieldErrorText = "Заполните это поле";
                var mainPage = new MainPage(Driver);
                var toyInfoPage = new ToyInfoPage(Driver);

                mainPage.SelectToyClick();
                toyInfoPage.CheaperClick();
                toyInfoPage.SendChiperClick();

                Assert.AreEqual(emptyFieldErrorText, toyInfoPage.GetChipNameErrorText());
            });
        }

        [Test]
        public void PurchaseToy_EnterInvalidMailForChiperItem_InvalidEmailErrorAppears()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string emailErrorText = "Неверный формат";
                var mainPage = new MainPage(Driver);
                var toyInfoPage = new ToyInfoPage(Driver);

                mainPage.SelectToyClick();
                toyInfoPage.PurchaseToyClick();
                toyInfoPage.ChiperEnterEmail(TestDataReader.GetTestData("Email"));
                toyInfoPage.SendOrderClick();

                Assert.AreEqual(emailErrorText, toyInfoPage.ChiperGetEmailError());
            });
        }

        [Test]
        public void Login_EnterEmptyLogin_InvalidLoginErrorAppears()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string emailErrorText = "Заполните это поле";
                var mainPage = new MainPage(Driver);
                mainPage.LoginClick();
                mainPage.Login2Click();

                Assert.AreEqual(emailErrorText, mainPage.GetLoginError());
            });
        }
    }
}
