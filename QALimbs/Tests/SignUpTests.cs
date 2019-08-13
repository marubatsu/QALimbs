using NUnit.Framework;
using QALimbs.Actions;

namespace QALimbs.Tests
{
    public class SignUpTests
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

        [Test, Order(1), Property("Priority", "Critical"), Description("Registrarse con email en la plataforma.")]
        public void SignUp()
        {
            HomeActions.NavigateToRegisterForm();
            SignUpActions.FillSignUpForm(Data.Credentials.Valid.PasswordRequester);
            Assert.AreEqual(Data.Texts.SignUp.ConfirmEmail, SignUpActions.GetConfirmationMessage());
        }
    }
}
