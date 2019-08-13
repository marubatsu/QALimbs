using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace QALimbs.PageObjects
{
    class ViewRequestPage
    {
        public ViewRequestPage()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='card card-l'][1]/table/tbody/tr[5]/td[2]")]
        public IWebElement TxtComentarios { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[@class='text-danger']")]
        public IWebElement TxtNoDesign { get; set; }

    }
}
