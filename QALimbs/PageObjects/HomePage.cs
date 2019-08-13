using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace QALimbs.PageObjects
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//li[@class='perfil_name']/a[@href='/Account/Login']")]
        public IWebElement LnkLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='opciones_perfil']/li/a[@href='/Account/Register']")]
        public IWebElement LnkRegister { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='cont_inicio']/div/a[@href='/Help/Pedir']")]
        public IWebElement LnkPedirProtesis { get; set; }

        [FindsBy(How = How.Id, Using = "registrarse_button")]
        public IWebElement LnkIngresar { get; set; }
    }
}
