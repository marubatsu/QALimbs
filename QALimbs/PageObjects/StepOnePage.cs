using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace QALimbs.PageObjects
{
    class StepOnePage
    {
        public StepOnePage()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@js_val='Left']/p")]
        public IWebElement BtnLeft { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@js_val='Right']/p")]
        public IWebElement BtnRight { get; set; }
    }
}
