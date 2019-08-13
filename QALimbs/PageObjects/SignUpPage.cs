using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace QALimbs.PageObjects
{
    public class SignUpPage
    {
        public SignUpPage()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement TxtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "ConfirmPassword")]
        public IWebElement TxtConfirmPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@data-callback='OnSubmit']")]
        public IWebElement BtnSubmit { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='cont-wr']/h2")]
        public IWebElement MsgConfirmEmail { get; set; }

    }
}
