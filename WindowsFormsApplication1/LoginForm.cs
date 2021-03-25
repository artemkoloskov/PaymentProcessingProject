using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PaymentProcessingProject
{
    public partial class LoginForm : Form
    /*
     * Класс формы логина
     */
    {
        public LoginForm()
        // инициализации формы
        {
            InitializeComponent();
        }

        private void getLogins()
        /*
         * для удобства тестирования этот метод загружает все логины из базы и отправляет их в комбо-бокс
         * так же он записывает в словарь логины и пароли для сопоставления в будущем
         */
        {
            SqlConnection dbConnection = Program.initializeDBConnectionString(
                getDataSourceString(),
                getInitialCatalogString(),
                getUserIDString(),
                getDBPasswordString());

            try
            {
                dbConnection.Open();

                using (SqlDataReader dbReader = Program.initializeSQLCommand("SELECT * FROM dbo.LoginTable", dbConnection).ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        loginsPasswordsDictionary.Add(dbReader[1].ToString(), dbReader[2].ToString());
                        idLoginsDictionary.Add(dbReader[1].ToString(), Int32.Parse(dbReader[0].ToString()));
                        loginComboBox.Items.Add(dbReader[1]);
                    }
                }
                dbConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(Constants.LOGIN_FORM_DB_UNAVAILABLE_ERROR_STRING);
            }
           
            
        }

        private void switchDevMode ()
        /*
         * Метод включает и выключает режим разработки. в режиме разработки 
         * на форме отображаются доступные для изменения данные для подключения к БД
         */
        {
            if (devModeCheckBox.Checked)
            {
                this.ClientSize = new System.Drawing.Size(268, 252);
                getLoginsButton.Enabled = true;
            }
            else 
            {
                this.ClientSize = new System.Drawing.Size(268, 115);
                getLoginsButton.Enabled = false;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        /*
         * обработка нажатия на кнопку OK. при успешном сравнении логина и пароля
         * запускает главную форму, передав ей данные о клиенте и убивает форму лолгина
         */
        {
            // подключение к базе, загрузка логинов и паролей для проверки соответсвия
            getLogins();

            string str = "";

            // проверка на пустые поля ввода
            if (loginComboBox.Text != "" || passwordTextBox.Text != "")
            {
                if (loginsPasswordsDictionary.TryGetValue(loginComboBox.Text, out str) && str == passwordTextBox.Text)
                {
                    int clientID = 0;
                    idLoginsDictionary.TryGetValue(loginComboBox.Text, out clientID);
                    MainForm mainForm = new MainForm(clientID, loginComboBox.Text);
                    this.Dispose();
                    mainForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Constants.LOGIN_FORM_WRONG_LOGIN_PASS_ERROR_STRING);
                }
            }
            else
            {
                MessageBox.Show(Constants.LOGIN_FORM_SOME_FIELDS_ARE_EMPTY_ERROR_STRING);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void devModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switchDevMode();
        }

        public string getDataSourceString()
        {
            return dataSourceTextBox.Text;
        }

        public string getInitialCatalogString()
        {
            return initialCatalogTextBox.Text;
        }

        public string getUserIDString()
        {
            return userIDTextBox.Text;
        }

        public string getDBPasswordString()
        {
            return dbPasswordTextBox.Text;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private Dictionary<string, string> loginsPasswordsDictionary = new Dictionary<string, string>();
        private Dictionary<string, int> idLoginsDictionary = new Dictionary<string, int>();

        private void getLoginsButton_Click(object sender, EventArgs e)
        {
            getLogins();
        }
    }
}
