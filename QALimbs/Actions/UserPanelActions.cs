using OpenQA.Selenium;
using QALimbs.PageObjects;
using System.Threading;

namespace QALimbs.Actions
{
    class UserPanelActions
    {
        public static void ClickOnNewRequestButton()
        {
            UserPanelPage userPanelPage = new UserPanelPage();
            userPanelPage.BtnNewRequest.Click();
            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
        }

        public static void NavigateToLastRequest()
        {
            UserPanelPage userPanelPage = new UserPanelPage();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;

            js.ExecuteScript("arguments[0].scrollIntoView();", userPanelPage.LastRequest);
            userPanelPage.ListNewRequests.Click();
            //userPanelPage.CheckNewRequest.Click();
            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
        }

        public static string GetUserEmail()
        {
            UserPanelPage userPanelPage = new UserPanelPage();
            return userPanelPage.LinkEmail.Text;
        }

        public static bool isBtnNewRequestDisplayed()
        {
            UserPanelPage userPanelPage = new UserPanelPage();
            return userPanelPage.BtnNewRequest.Displayed;
        }

        public static bool isStatisticsSectionDisplayed()
        {
            UserPanelPage userPanelPage = new UserPanelPage();
            return userPanelPage.DivStatistics.Displayed;
        }
    }
}
