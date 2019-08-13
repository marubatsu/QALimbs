using QALimbs.PageObjects;

namespace QALimbs.Actions
{
    class LoginActions
    {
        public static void FillLoginForm(string email, string password)
        {
            LoginPage loginPage = new LoginPage();

            loginPage.FieldEmail.SendKeys(email);
            loginPage.FieldPassword.SendKeys(password);
            loginPage.BtnSubmit.Click();

            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
        }

        public static void ClearFields()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.FieldEmail.Clear();
            loginPage.FieldPassword.Clear();
        }

        public static string GetErrorMessageInvalidUserPass()
        {
            LoginPage loginPage = new LoginPage();
            return loginPage.MsgInvalidUserPass.Text;
        }

        public static string GetErrorMessageBlockedEmail()
        {
            LoginPage loginPage = new LoginPage();
            return loginPage.MsgBlockedEmail.Text;
        }
    }
}
