using QALimbs.PageObjects;
using System;
using System.Threading;

namespace QALimbs.Actions
{
    class SignUpActions
    {
        public static void FillSignUpForm(string password)
        {
            SignUpPage signUpPage = new SignUpPage();
            string email = GenerateNewEmail();

            signUpPage.TxtEmail.SendKeys(email);
            signUpPage.TxtPassword.SendKeys(password);
            signUpPage.TxtConfirmPassword.SendKeys(password);
            signUpPage.BtnSubmit.Click();
            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
        }

        public static string GenerateNewEmail()
        {
            string date = DateTime.Now.ToString("ddMMyyyyHHmmss");
            string email = Data.Credentials.Valid.BaseEmail + date + Data.Credentials.Valid.BaseDomain;
            return email;
        }

        public static string GetConfirmationMessage()
        {
            SignUpPage signUpPage = new SignUpPage();
            return signUpPage.MsgConfirmEmail.Text;
        }

    }
}
