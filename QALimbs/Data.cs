using System.Configuration;

namespace QALimbs
{
    public static class Data
    {
        public static string Browser = ConfigurationManager.AppSettings.Get("Browser");
        public static string BaseURL = "https://limbs-staging.azurewebsites.net/";
        public static int ElementsWaitingTimeout = 5;

        public static class Credentials
        {
            public static class Valid
            {
                public static string EmailRequester = ConfigurationManager.AppSettings.Get("ValidRequesterEmail");
                public static string PasswordRequester = ConfigurationManager.AppSettings.Get("ValidRequesterPassword");
                public static string EmailAmbassador = ConfigurationManager.AppSettings.Get("ValidAmbassadorEmail");
                public static string PasswordAmbassador = ConfigurationManager.AppSettings.Get("ValidAmbassadorPassword");
                public static string BaseEmail = ConfigurationManager.AppSettings.Get("BaseEmail");
                public static string BaseDomain = ConfigurationManager.AppSettings.Get("BaseEmailDomain");
            }
            public static class Invalid
            {
                public static class Email
                {
                    public static string Blocked = ConfigurationManager.AppSettings.Get("BlockedEmail");
                    public static string Format = "invalid@format";
                    public static string NonRegistered = "nonregistered@email.com";
                }

                public static class Password
                {
                    public static string LessThanSixCharacters = "12345";
                    public static string Incorrect = "INCORRECT";
                }
            }
        }

        public static class ErrorMessages
        {
            public static class Login
            {
                public static string InvalidUserPass = "Usuario o contraseña incorrectos";
                public static string BlockedEmail = "Esta cuenta ha sido bloqueada, por favor inténtelo de nuevo más tarde";
            }
        }

        public static class Texts
        {
            public static class Login
            {
                public static string LoginButton = "Iniciar sesión";
            }

            public static class SignUp
            {
                public static string ConfirmEmail = "Confirmá tu email.";
            }
        }

        //Image for a new request
        public static string FilePathImage = ConfigurationManager.AppSettings.Get("FilePathImage");
    }
}
