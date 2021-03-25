using System.Windows.Forms;
using System.Data.SqlClient;

namespace PaymentProcessingProject
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Вызов форма входа
            LoginForm loginForm = new LoginForm();

            dbDataSourceString = loginForm.getDataSourceString();
            dbInitialCatalogString = loginForm.getInitialCatalogString();
            dbUserIDString = loginForm.getUserIDString();
            dbPasswordString = loginForm.getDBPasswordString();

            loginForm.Show();
            Application.Run();
        }

        public static SqlConnection initializeDBConnectionString(string dataSourcerStr, string initCatalogStr, string userStr, string passStr)
        /*
        * Метод инициализирует и возвращает соединение с SQL-базой. Данные для инициализации берутся с формы LoginForm
        * Этот метод будет использоваться во всех соединениях приложения с базой
        */
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = dataSourcerStr;
            connectionStringBuilder.InitialCatalog = initCatalogStr;
            connectionStringBuilder.UserID = userStr;
            connectionStringBuilder.Password = passStr;
            connectionStringBuilder.ConnectTimeout = 5;

            string sqlConnectionString = connectionStringBuilder.ToString();

            return new SqlConnection(sqlConnectionString);
        }

        public static SqlCommand initializeSQLCommand(string query, SqlConnection conn)
        /*
        * Метод возвращает комманду для выполнения при обращении к базе
        */
        {
            return new SqlCommand(query, conn);
        }

        public static SqlConnection dbConnection = null;
        public static string dbDataSourceString = "";
        public static string dbInitialCatalogString = "";
        public static string dbUserIDString = "";
        public static string dbPasswordString = "";
    }
}
