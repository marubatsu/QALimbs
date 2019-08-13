using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace QALimbs.PageObjects
{
    class StepTwoPage
    {
        public StepTwoPage()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='1']")]
        public IWebElement BtnTipoAmp1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='2']")]
        public IWebElement BtnTipoAmp2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='3']")]
        public IWebElement BtnTipoAmp3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='4']")]
        public IWebElement BtnTipoAmp4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='5']")]
        public IWebElement BtnTipoAmp5 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='6']")]
        public IWebElement BtnTipoAmp6 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='7']")]
        public IWebElement BtnTipoAmp7 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='8']")]
        public IWebElement BtnTipoAmp8 { get; set; }

        [FindsBy(How = How.Id, Using = "enviar")]
        public IWebElement BtnNext { get; set; }
    }
}
