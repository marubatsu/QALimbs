using QALimbs.PageObjects;
using System;
using System.Threading;

namespace QALimbs.Actions
{
    class NewRequestActions
    {
        public static string Comments;
        public static string NewRequestWithDesign(string selectArm, string selectAmp, string selectColor)
        {
            StepTwoPage stepTwoPage = new StepTwoPage();
            StepFourPage stepFourPage = new StepFourPage();
            string values = selectArm + ", " + selectAmp + ", " + selectColor + ".";

            SelectArm(selectArm);
            SelectAmp(selectAmp);
            stepTwoPage.BtnNext.Click();
            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
            UploadImage();
            SelectColor(selectColor);
            Comments = EnterComment(values);
            stepFourPage.BtnSendRequest.Click();
            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
            return Comments;
        }

        public static string NewRequestWithoutDesign(string selectArm, string selectAmp)
        {
            StepTwoPage stepTwoPage = new StepTwoPage();
            StepFourPage stepFourPage = new StepFourPage();
            string values = selectArm + ", " + selectAmp + ".";

            SelectArm(selectArm);
            SelectAmp(selectAmp);
            stepTwoPage.BtnNext.Click();
            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
            UploadImage();
            Comments = EnterComment(values);
            stepFourPage.BtnSendRequest.Click();
            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
            return Comments;
        }

        public static void SelectArm(string selectArm)
        {
            StepOnePage stepOnePage = new StepOnePage();

            if (selectArm.Equals("left"))
            {
                stepOnePage.BtnLeft.Click();
            }
            else if (selectArm.Equals("right"))
            {
                stepOnePage.BtnRight.Click();
            }
            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
        }

        public static void SelectAmp(string selectAmp)
        {
            StepTwoPage stepTwoPage = new StepTwoPage();

            switch (selectAmp)
            {
                case "1":
                    stepTwoPage.BtnTipoAmp1.Click();
                    break;
                case "2":
                    stepTwoPage.BtnTipoAmp2.Click();
                    break;
                case "3":
                    stepTwoPage.BtnTipoAmp3.Click();
                    break;
                case "4":
                    stepTwoPage.BtnTipoAmp4.Click();
                    break;
                case "5":
                    stepTwoPage.BtnTipoAmp5.Click();
                    break;
                case "6":
                    stepTwoPage.BtnTipoAmp6.Click();
                    break;
                case "7":
                    stepTwoPage.BtnTipoAmp7.Click();
                    break;
                case "8":
                    stepTwoPage.BtnTipoAmp3.Click();
                    break;
            }
        }

        public static void UploadImage()
        {
            StepThreePage stepThreePage = new StepThreePage();

            string filePath = Data.FilePathImage;
            stepThreePage.InputImage.SendKeys(filePath);
            Thread.Sleep(5000); // Tiempo de espera para cargar la imagen
            stepThreePage.BtnNext.Click();
            Driver.WaitForElementUpTo(Data.ElementsWaitingTimeout);
        }

        public static void SelectColor(string selectColor)
        {
            StepFourPage stepFourPage = new StepFourPage();

            switch (selectColor)
            {
                case "A":
                    stepFourPage.BtnColorA.Click();
                    break;
                case "B":
                    stepFourPage.BtnColorB.Click();
                    break;
                case "C":
                    stepFourPage.BtnColorC.Click();
                    break;
                case "D":
                    stepFourPage.BtnColorD.Click();
                    break;
                case "E":
                    stepFourPage.BtnColorE.Click();
                    break;
                case "F":
                    stepFourPage.BtnColorF.Click();
                    break;
            }
        }

        public static string EnterComment(string values)
        {
            StepFourPage stepFourPage = new StepFourPage();

            string date = DateTime.Now.ToString("dd/MM/yyyy H:mm:ss");
            string comment = "Prueba automatizada - " + date + ". Valores: " + values;
            stepFourPage.FieldComments.SendKeys(comment);
            return comment;
        }
    }
}
