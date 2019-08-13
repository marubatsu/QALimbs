using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace QALimbs.PageObjects
{
    class StepThreePage
    {
        public StepThreePage()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='dz-default dz-message']")]
        public IWebElement BtnUploadImage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='dz-hidden-input']")]
        public IWebElement InputImage { get; set; }

        [FindsBy(How = How.Id, Using = "enviar")]
        public IWebElement BtnNext { get; set; }

    }
}
