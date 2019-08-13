using QALimbs.PageObjects;

namespace QALimbs.Actions
{
    class SignOffActions
    {
        public static void SignOff()
        {
            UserPanelPage userPanelPage = new UserPanelPage();
            userPanelPage.LinkSignOff.Click();
            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
        }
    }
}
