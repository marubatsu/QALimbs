using NUnit.Framework;
using QALimbs.Actions;

namespace QALimbs.Tests
{
    public class SignOffTests
    {
        [SetUp]
        public void Initialize()
        {
            Config.InitializeDriver();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.WebDriver.Quit();
        }

        [Test, Order(1), Property("Priority","Critical"), Description("Cerrar sesión.")]
        public void SignOff()
        {
            HomeActions.NavigateToLoginForm();
            LoginActions.FillLoginForm(Data.Credentials.Valid.EmailRequester, Data.Credentials.Valid.PasswordRequester);
            SignOffActions.SignOff();
            Assert.AreEqual(Data.Texts.Login.LoginButton, HomeActions.GetLoginLinkText());
        }
    }
}
