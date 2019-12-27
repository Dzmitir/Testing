using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace GitHubAutomation.Pages
{
    public class MainPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='bx_3966226736_10233_HIT']/div/div[2]/div[1]/a")]
        private IWebElement SelectToyButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[1]/div/div/div[2]/div/div/a")]
        private IWebElement LoginButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='ajax_auth']/div/div[3]/div[1]/a")]
        private IWebElement RegisterButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='ajax_auth']/div[1]")]
        private IWebElement WrongPasswordBlock { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='USER_PASSWORD_POPUP']")]
        private IWebElement PasswordTextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='USER_LOGIN_POPUP']")]
        private IWebElement LoginTextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='avtorization-form']/div[3]/div[2]/input")]
        private IWebElement LoginButton2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='USER_PASSWORD_POPUP-error']")]
        private IWebElement PasswordErrorLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='USER_LOGIN_POPUP-error']")]
        private IWebElement LoginErrorLabel { get; set; }

        public MainPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public void SelectToyClick() => SelectToyButton.Click();
        public void LoginClick() => LoginButton.Click();
        public void RegisterClick() => RegisterButton.Click();
        public void Login2Click() => LoginButton2.Click();
        public void EnterPassword(string password) => PasswordTextBox.SendKeys(password);
        public void EnterLogin(string email) => LoginTextBox.SendKeys(email);
        public bool GetWrongCredentialsError() => WrongPasswordBlock.Displayed;
        public string GetPasswordError() => PasswordErrorLabel.Text;
        public string GetLoginError() => LoginErrorLabel.Text;

    }
}
