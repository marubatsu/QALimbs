using QALimbs.PageObjects;

namespace QALimbs.Actions
{
    class ViewRequestActions
    {
        public static string GetComments()
        {
            ViewRequestPage viewRequestPage = new ViewRequestPage();
            return viewRequestPage.TxtComentarios.Text;
        }

        public static bool IsNoDesignTextDisplayed()
        {
            ViewRequestPage viewRequestPage = new ViewRequestPage();
            return viewRequestPage.TxtNoDesign.Displayed;
        }
    }
}
