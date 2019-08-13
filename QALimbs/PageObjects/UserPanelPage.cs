using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace QALimbs.PageObjects
{
    class UserPanelPage
    {
        public UserPanelPage()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@title='Manage']")]
        public IWebElement LinkEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='cerrar_sesion']")]
        public IWebElement LinkSignOff { get; set; }

        [FindsBy(How = How.Name, Using = "btn_pedir")]
        public IWebElement BtnNewRequest { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/a[last()]")]
        public IWebElement LastRequest { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='pedidosActivos']")]
        public IWebElement ListNewRequests { get; set; }

        [FindsBy(How = How.Id, Using = "estadistica_emb")]
        public IWebElement DivStatistics { get; set; }

    }
}
