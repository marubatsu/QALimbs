using NUnit.Framework;
using QALimbs.Actions;

namespace QALimbs.Tests
{
    public class LoginTests
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

        [Test, Order(1), Property("Priority","Critical"), Description("Iniciar sesión con usuario prótesis registrado con email.")]
        public void ValidLoginRequester()
        {
            HomeActions.NavigateToLoginForm();
            LoginActions.FillLoginForm(Data.Credentials.Valid.EmailRequester, Data.Credentials.Valid.PasswordRequester);
            
            Assert.Multiple(() =>
            {
                Assert.AreEqual(Data.Credentials.Valid.EmailRequester, UserPanelActions.GetUserEmail());
                Assert.That(UserPanelActions.isBtnNewRequestDisplayed());
            });
        }

        [Test, Order(2), Property("Priority", "High"), Description("Iniciar sesión con usuario embajador registrado con email.")]
        public void ValidLoginAmbassador()
        {
            HomeActions.NavigateToLoginForm();
            LoginActions.FillLoginForm(Data.Credentials.Valid.EmailAmbassador, Data.Credentials.Valid.PasswordAmbassador);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(Data.Credentials.Valid.EmailAmbassador, UserPanelActions.GetUserEmail());
                Assert.That(UserPanelActions.isStatisticsSectionDisplayed());
            });
        }

        [Test, Order(3), Property("Priority", "Low"), Description("Ingresar contraseña incorrecta menos de 5 veces.")]
        public void IncorrectPassword()
        {
            HomeActions.NavigateToLoginForm();
            LoginActions.FillLoginForm(Data.Credentials.Valid.EmailRequester, Data.Credentials.Invalid.Password.Incorrect);
            Assert.AreEqual(Data.ErrorMessages.Login.InvalidUserPass, LoginActions.GetErrorMessageInvalidUserPass());
        }

        [Test, Order(4), Property("Priority", "Low"), Description("Ingresar contraseña incorrecta 5 veces.")]
        public void BlockedEmail()
        {
            HomeActions.NavigateToLoginForm();
            for (int i = 0; i < 5; i++)
            {
                LoginActions.ClearFields();
                LoginActions.FillLoginForm(Data.Credentials.Invalid.Email.Blocked, Data.Credentials.Invalid.Password.Incorrect);
                Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
            }
            Assert.AreEqual(Data.ErrorMessages.Login.BlockedEmail, LoginActions.GetErrorMessageBlockedEmail());
        }

        [Test, Order(5), Property("Priority", "Low"), Description("Ingresar con email no registrado en la plataforma.")]
        public void NonRegisteredEmail()
        {
            HomeActions.NavigateToLoginForm();
            LoginActions.FillLoginForm(Data.Credentials.Invalid.Email.NonRegistered, Data.Credentials.Valid.PasswordRequester);
            Assert.AreEqual(Data.ErrorMessages.Login.InvalidUserPass, LoginActions.GetErrorMessageInvalidUserPass());
        }
    }
}
