using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace QALimbs
{
    public static class Config
    {
        public static void InitializeDriver()
        {
            Driver.SelectDriver(Data.Browser);
            Driver.WebDriver.Navigate().GoToUrl(Data.BaseURL);
            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
        }
    }
}
