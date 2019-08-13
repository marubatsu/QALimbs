using NUnit.Framework;
using QALimbs.Actions;

namespace QALimbs.Tests
{
    class NewRequestTests
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

        [Test, Order(1), Property("Priority", "Critical"), Description("Solicitar pedido con diseño.")]
        [TestCase("left","3","A")]
        [TestCase("right", "3", "B")]
        [TestCase("left", "4", "C")]
        [TestCase("right", "4", "D")]
        [TestCase("left", "5", "E")]
        [TestCase("right", "5", "F")]
        [TestCase("left", "6", "A")]
        [TestCase("right", "6", "B")]
        public void RequestWithDesign(string selectArm, string selectAmp, string selectColor)
        {
            string Comments;

            HomeActions.NavigateToLoginForm();
            LoginActions.FillLoginForm(Data.Credentials.Valid.EmailRequester, Data.Credentials.Valid.PasswordRequester);
            UserPanelActions.ClickOnNewRequestButton();
            Comments = NewRequestActions.NewRequestWithDesign(selectArm, selectAmp, selectColor);
            UserPanelActions.NavigateToLastRequest();

            Assert.AreEqual(ViewRequestActions.GetComments(), Comments);
        }

        [Test, Order(2), Property("Priority", "Medium"), Description("Solicitar pedido sin diseño.")]
        [TestCase("left", "1")]
        [TestCase("right", "1")]
        [TestCase("left", "2")]
        [TestCase("right", "2")]
        [TestCase("left", "7")]
        [TestCase("right", "7")]
        [TestCase("left", "8")]
        [TestCase("right", "8")]
        public void RequestWithoutDesign(string selectArm, string selectAmp)
        {
            string Comments;

            HomeActions.NavigateToLoginForm();
            LoginActions.FillLoginForm(Data.Credentials.Valid.EmailRequester, Data.Credentials.Valid.PasswordRequester);
            UserPanelActions.ClickOnNewRequestButton();
            Comments = NewRequestActions.NewRequestWithoutDesign(selectArm, selectAmp);
            UserPanelActions.NavigateToLastRequest();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(ViewRequestActions.GetComments(), Comments);
                Assert.That(ViewRequestActions.IsNoDesignTextDisplayed);
            });            
        }
    }
}
