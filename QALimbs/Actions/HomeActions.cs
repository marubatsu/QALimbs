using QALimbs.PageObjects;

namespace QALimbs.Actions
{
    class HomeActions
    {
        public static void NavigateToLoginForm()
        {
            HomePage homePage = new HomePage();
            homePage.LnkIngresar.Click();
            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
        }

        public static void NavigateToRegisterForm()
        {
            HomePage homePage = new HomePage();
            homePage.LnkRegister.Click();
            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
        }

        public static string GetLoginLinkText()
        {
            HomePage homePage = new HomePage();
            return homePage.LnkLogin.Text;
        }
    }
}
