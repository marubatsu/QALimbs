using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace QALimbs
{
    public class Driver
    {
        public static IWebDriver WebDriver { get; set; }

        public static void SelectDriver(string browser) {
            switch (browser)
            {
                case "Chrome":
                    WebDriver = new ChromeDriver();
                    break;
                case "Firefox":
                    FirefoxOptions options = new FirefoxOptions();
                    options.SetPreference("dom.webdriver.enabled", false);
                    WebDriver = new FirefoxDriver(options);
                    break;
            }
        }

        public static void WaitForElementUpTo(int seconds)
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }
    }
}
