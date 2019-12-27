using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace GitHubAutomation.Pages
{
    class ToyInfoPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='bx_117848907_10233']/div[2]/div/div[2]/div[2]/div[2]/div[2]/div/div[3]/span")]
        private IWebElement PurchaseToyButton { get; set; }
        [FindsBy(How = How.Id, Using = "one_click_buy_form_button")]
        private IWebElement SendOrderButton { get; set; }
        [FindsBy(How = How.Id, Using = "one_click_buy_id_FIO-error")]
        private IWebElement NameErrorLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='one_click_buy_id_EMAIL']")]
        private IWebElement EmailTextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='one_click_buy_id_EMAIL-error']")]
        private IWebElement EmailErrorLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='bx_117848907_10233']/div[2]/div/div[2]/div[2]/div[2]/div[1]/div[2]/div[2]/span")]
        private IWebElement ChiperButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='form_text_55-error']")]
        private IWebElement ChiperFormNameErrorLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='comp_564cacf960a73b22a6027a9b490bc5bd']/div/form/div[2]/input")]
        private IWebElement SendChiperButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='comp_564cacf960a73b22a6027a9b490bc5bd']/div/form/div[1]/div[3]/input")]
        private IWebElement ChiperEmailTextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='form_email_57-error']")]
        private IWebElement ChiperEmailErrorLabel { get; set; }





        private readonly IWebDriver browser;

        public ToyInfoPage(IWebDriver browser)
        {
            this.browser = browser;
            PageFactory.InitElements(browser, this);
        }

        public ToyInfoPage PurchaseToyClick() 
        { 
            PurchaseToyButton.Click();
            return this;
        }

        public ToyInfoPage SendOrderClick()
        {
            SendOrderButton.Click();
            return this;
        }

        public ToyInfoPage CheaperClick()
        {
            ChiperButton.Click();
            return this;
        }

        public ToyInfoPage SendChiperClick()
        {
            SendChiperButton.Click();
            return this;
        }


        public string GetNameErrorText() => NameErrorLabel.Text;
        public void EnterEmail(string email) => EmailTextBox.SendKeys(email);
        public string GetEmailError() => EmailErrorLabel.Text;
        public string GetChipNameErrorText() => ChiperFormNameErrorLabel.Text;
        public void ChiperEnterEmail(string email) => EmailTextBox.SendKeys(email);
        public string ChiperGetEmailError() => EmailErrorLabel.Text;
    }
}
