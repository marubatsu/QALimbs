using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace QALimbs.PageObjects
{
    class StepFourPage
    {
        public StepFourPage()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='A']")]
        public IWebElement BtnColorA { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='B']")]
        public IWebElement BtnColorB { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='C']")]
        public IWebElement BtnColorC { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='D']")]
        public IWebElement BtnColorD { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='E']")]
        public IWebElement BtnColorE { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@js_value='F']")]
        public IWebElement BtnColorF { get; set; }

        [FindsBy(How = How.Id, Using = "Comments")]
        public IWebElement FieldComments { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Enviar pedido']")]
        public IWebElement BtnSendRequest { get; set; }

    }
}
