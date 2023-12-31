﻿
namespace MVC;

public static class Views
{
    public static class Common
    {
        public static class Books
        {
            public const string BooksIndex = "~/Modules/Common/Books/BooksIndex.cshtml";
        }

        public static class Dashboard
        {
            public const string DashboardIndex = "~/Modules/Common/Dashboard/DashboardIndex.cshtml";
        }

        public static class REACTPage
        {
            public const string REACTIndex = "~/Modules/Common/REACTPage/REACTIndex.cshtml";
        }
    }

    public static class Errors
    {
        public const string AccessDenied = "~/Views/Errors/AccessDenied.cshtml";
        public const string ValidationError = "~/Views/Errors/ValidationError.cshtml";
    }

    public static class Membership
    {
        public static class Account
        {
            public static class ChangePassword
            {
                public const string ChangePasswordPage = "~/Modules/Membership/Account/ChangePassword/ChangePasswordPage.cshtml";
            }

            public static class ForgotPassword
            {
                public const string ForgotPasswordPage = "~/Modules/Membership/Account/ForgotPassword/ForgotPasswordPage.cshtml";
            }

            public static class Login
            {
                public const string LoginPage = "~/Modules/Membership/Account/Login/LoginPage.cshtml";
            }

            public static class ResetPassword
            {
                public const string ResetPasswordEmail = "~/Modules/Membership/Account/ResetPassword/ResetPasswordEmail.cshtml";
                public const string ResetPasswordPage = "~/Modules/Membership/Account/ResetPassword/ResetPasswordPage.cshtml";
            }

            public static class SignUp
            {
                public const string ActivateEmail = "~/Modules/Membership/Account/SignUp/ActivateEmail.cshtml";
                public const string SignUpPage = "~/Modules/Membership/Account/SignUp/SignUpPage.cshtml";
            }
        }
    }

    public static class Shared
    {
        public const string _Layout = "~/Views/Shared/_Layout.cshtml";
        public const string _LayoutHead = "~/Views/Shared/_LayoutHead.cshtml";
        public const string _LayoutNoNavigation = "~/Views/Shared/_LayoutNoNavigation.cshtml";
        public const string _Sidebar = "~/Views/Shared/_Sidebar.cshtml";
        public const string Error = "~/Views/Shared/Error.cshtml";
    }
}