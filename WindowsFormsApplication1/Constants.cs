
namespace PaymentProcessingProject
{
    class Constants
    // класс для хранения и удобного редактирования используемых приложением констант
    {
        // строковые константы для LoginForm
        public const string LOGIN_FORM_DATA_SOURCE_DEFAULT_STRING = "SUPACOMPUTA";
        public const string LOGIN_FORM_INITIAL_CATALOG_DEFAULT_STRING = "PayProcDB";
        public const string LOGIN_FORM_USER_ID_DEFAULT_STRING = "sa";
        public const string LOGIN_FORM_PASSWORD_DEFAULT_STRING = "DbAdmin1234";
        public const string LOGIN_FORM_DB_UNAVAILABLE_ERROR_STRING = "Couldn't reach for DB, please check settings in DevMode and restart app";
        public const string LOGIN_FORM_WRONG_LOGIN_PASS_ERROR_STRING = "Entered info is incorrect";
        public const string LOGIN_FORM_SOME_FIELDS_ARE_EMPTY_ERROR_STRING = "Please enter login and password";
        public const string LOGIN_FORM_LOGIN_LABEL_STRING = "Login";
        public const string LOGIN_FORM_PASSWORD_LABEL_STRING = "Password";
        public const string LOGIN_FORM_OK_BUTTON_STRING = "OK";
        public const string LOGIN_FORM_CANCEL_BUTTON_STRING = "Cancel";
        public const string LOGIN_FORM_DEVMODE_CHECKBOX_STRING = "DevMode";
        public const string LOGIN_FORM_DBHOST_LABEL_STRING = "DB host";
        public const string LOGIN_FORM_DBNAME_LABEL_STRING = "DB name";
        public const string LOGIN_FORM_DBUSERID_LABEL_STRING = "DB user";
        public const string LOGIN_FORM_DBPASSWORD_LABEL_STRING = "DB pass";
        public const string LOGIN_FORM_CONNECTION_OPTIONS_LABEL_STRING = "DB connection options";
        public const string LOGIN_FORM_TITLE_STRING = "Please login";

        // строковые константы для MainForm
        public const string MAIN_FORM_NO_DEBT_ERROR_STRING = "There's no debt to pay for";
        public const string MAIN_FORM_INVALID_AMOUNT_ERROR_STRING = "Please enter valid amount";
        public const string MAIN_FORM_GREETINGS_LABEL_STRING = "Hello, Mr. ";
        public const string MAIN_FORM_PROVIDED_DERVICES_LABEL_STRING = "Provided services and payments:";
        public const string MAIN_FORM_NEW_PAYMENT_LABEL_STRING = "New payment:";
        public const string MAIN_FORM_ENTER_AMOUNT_LABEL_STRING = "Enter amount:";
        public const string MAIN_FORM_AMOUNT_DEFAULT_STRING = "0,00";
        public const string MAIN_FORM_PAY_BUTTON_STRING = "Pay";
        public const string MAIN_FORM_EXIT_BUTTON_STRING = "Exit";
        public const string MAIN_FORM_TITLE_STRING = "Payment Processing";
    }
}
