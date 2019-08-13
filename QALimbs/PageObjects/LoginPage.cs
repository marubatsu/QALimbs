using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace QALimbs.PageObjects
{
    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement FieldEmail { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement FieldPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Ingresar']")]
        public IWebElement BtnSubmit { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div/ul/li")]
        public IWebElement MsgInvalidUserPass { get; set; }

        [FindsBy(How = How.XPath, Using = "//hgroup/h2[@class='text-danger']")]
        public IWebElement MsgBlockedEmail { get; set; }
        

    }
}
