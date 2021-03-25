using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PaymentProcessingProject
{
    public partial class MainForm : Form
    /*
     * Класс главной формы
     */
    {
        public MainForm(int clID, string clLogin)
        /*
         * Конструктор опирается на данные, введенные клиентом в форме логина
         */
        {
            InitializeComponent();

            // инициализации клиента для дальнейшего использования его данных в работе формы
            LoadClient(clID, clLogin);

            // Обновление названия окна формы на более персонализированный вариант
            this.Text += " - " + client.getFirstName() + " " + client.getSecondName();

            // обновление текста приветствия
            greetingLabel.Text += client.getSecondName() + "!";

            //обновление окна с данными по предоставленным клиенту услугам, внесенной им оплате и долгу
            displayServices();
        }

        private void displayServices()
        /*
         * Метод подключается к БД, делает запрос о предоставленных клиенту услугах, платежах и долге
         */
        {
            initDBConnection();

            dbConnection.Open();
            using (SqlCommand dbCommand = Program.initializeSQLCommand(
                "SELECT " +
	                "serv.Service, serv.Price, (prov.Total_Price/serv.Price) AS Times_Service_Provided, prov.Total_Price, pay.Total_Payed, (prov.Total_Price - pay.Total_Payed) AS Debt " + 
                "FROM " + 
	                "dbo.NameTable AS clients, dbo.ServicesTable AS serv, " + 
	                "(SELECT " + 
		                "prov.ClientID, prov.ServiceID, SUM(serv.Price) AS Total_Price  " + 
	                "FROM " + 
		                "dbo.ProvidedServicesTable AS prov, dbo.ServicesTable AS serv, dbo.NameTable AS clients " + 
	                "WHERE " + 
		                "prov.ClientID = clients.ID AND prov.ServiceID = serv.ID " + 
	                "GROUP BY " + 
		                "prov.ClientID, prov.ServiceID " + 
	                ") AS prov, " + 
	                "(SELECT " + 
		                "pay.ClientID, pay.ServiceID, SUM(Payment) AS Total_Payed " + 
	                "FROM " + 
		                "dbo.PaymentsTable AS pay " + 
	                "GROUP BY " + 
		                "pay.ClientID, pay.ServiceID " + 
	                ") AS pay " +
                "WHERE " +
                    "serv.ID = pay.ServiceID AND serv.ID = prov.ServiceID AND clients.ID = pay.ClientID AND clients.ID = prov.ClientID AND clients.ID = " + client.getID().ToString(), dbConnection))
            {
                dbCommand.CommandType = CommandType.Text;
                using (SqlDataAdapter dbAdapter = new SqlDataAdapter(dbCommand))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        dbAdapter.Fill(dataTable);

                        // загрузка полученных в результате запроса данных в окно на форме
                        servicesAndPayGridView.DataSource = dataTable;
                    }
                }
            }
            dbConnection.Close();
        }

        private void LoadClient(int id, string login)
        /*
         * метод инициализации клиента. Получив с формы логина уникальный ID и логин клиента метод делает запрос по ID
         * в базу данных и получает все данные для создания объекта Person
         */
        {
            initDBConnection();

            dbConnection.Open();
            using (SqlDataReader dbReader = Program.initializeSQLCommand("SELECT First_Name, Second_Name FROM dbo.NameTable WHERE ID = " + id.ToString(), dbConnection).ExecuteReader())
            {
                while (dbReader.Read())
                {
                    // инициализация клиента на основе полученных в резултате запроса данных
                    client = new Person(id, login, dbReader[0].ToString(), dbReader[1].ToString());
                }
            }
            dbConnection.Close();
        }

        private void initDBConnection() 
        // метод инициализации соединения с базой
        {
            dbConnection = Program.initializeDBConnectionString(
                Program.dbDataSourceString,
                Program.dbInitialCatalogString,
                Program.dbUserIDString,
                Program.dbPasswordString);
        }

        private void textBox1_Focused(object sender, EventArgs e) 
        // метод очищает поле для ввода суммы платежа при каждом новом входе в это поле
        {
            paymentAmountTextBox.Text = "";
        }

        private void payButton_Click(object sender, EventArgs e)
        /*
         * Обработка конпки Pay
         */
        {
            double amount = 0;

            // Парсинг суммы платежа из поля для ввода платежа
            if (Double.TryParse(paymentAmountTextBox.Text, out amount))
            {
                // объявление словарей содержащих данные о задолженностях по услугам и по расчитанной пропорционально оплате за услуги
                Dictionary<string, double> debtDictionary = new Dictionary<string, double>();
                Dictionary<string, double> payDictionary = new Dictionary<string, double>();

                // переменная для хранения общей суммы долга клиента
                double wholeDebt = 0;

                // заполнение словаря долгов и подсчет общей суммы долга. Данные берутся из загруженной на форме таблицы
                for (int rows = 0; rows < servicesAndPayGridView.Rows.Count - 1; rows++)
                {
                    
                    wholeDebt += Double.Parse(servicesAndPayGridView.Rows[rows].Cells[5].Value.ToString());
                    debtDictionary.Add(servicesAndPayGridView.Rows[rows].Cells[0].Value.ToString(), Double.Parse(servicesAndPayGridView.Rows[rows].Cells[5].Value.ToString()));
                }

                // Проверка на наличие долгаю Если долга нетб оплата не производится
                if (wholeDebt > 0)
                {                    
                    var debtEnumerator = debtDictionary.Keys.GetEnumerator();

                    //заполнение словаря пропорциональной оплаты услуг
                    for (int i = 0; i < debtDictionary.Count; i++)
                    {
                        debtEnumerator.MoveNext();
                        double debt = 0;
                        debtDictionary.TryGetValue(debtEnumerator.Current.ToString(), out debt);

                        payDictionary.Add(debtEnumerator.Current.ToString(), amount * debt / wholeDebt);
                    }


                    var payEnumerator = payDictionary.Keys.GetEnumerator();

                    // занесение заявок об оплате в базу данных
                    for (int i = 0; i < payDictionary.Count; i++)
                    {
                        payEnumerator.MoveNext();
                        double payAmount = 0;

                        //получение из словаря оплаты сумму для текущей услуги
                        payDictionary.TryGetValue(payEnumerator.Current.ToString(),out payAmount);

                        // отправка заявки в базу
                        makePayment(new Payment(getNewPaymentId(), client.getID(), getServiceId(payEnumerator.Current.ToString()), payAmount));
                    }

                    // обновление данных на форме
                    displayServices();                   
                }
                else
                {
                    MessageBox.Show(Constants.MAIN_FORM_NO_DEBT_ERROR_STRING);
                }
                
            }
            else
            {
                MessageBox.Show(Constants.MAIN_FORM_INVALID_AMOUNT_ERROR_STRING);
            }
        }

        private void makePayment(Payment pay)
        /*
         * Метод занесения заявки о платеже в базу
         */
        {
            initDBConnection();

            dbConnection.Open();
            var cmd = Program.initializeSQLCommand("INSERT INTO PayProcDB.dbo.PaymentsTable (ID, ClientID, ServiceID, Payment) VALUES (@ID, @ClientID, @ServiceID, @Payment)", dbConnection);
            cmd.Parameters.AddWithValue("@ID", pay.getID());
            cmd.Parameters.AddWithValue("@ClientID", pay.getClientID());
            cmd.Parameters.AddWithValue("@ServiceID", pay.getServiceID());
            cmd.Parameters.AddWithValue("@Payment", pay.getAmount());
            cmd.ExecuteNonQuery();

            dbConnection.Close();
        }

        private int getNewPaymentId() 
        /*
         * Метод запрашивает в базе ID последней заявки о платеже и возвращает следующий за ним ID для новой заявки
         */
        {
            int result = 0;
            initDBConnection();

            dbConnection.Open();
            using (SqlDataReader dbReader = Program.initializeSQLCommand("SELECT MAX(ID) FROM dbo.PaymentsTable", dbConnection).ExecuteReader())
            {
                while (dbReader.Read())
                {
                    result = Int32.Parse(dbReader[0].ToString()) + 1;
                }
            }
            dbConnection.Close();

            return result;
        }

        private int getServiceId(string servName)
        /*
         * Метод возвращает ID услуги из базы данных по ее названию
         */
        {
            int result = 0;
            initDBConnection();

            dbConnection.Open();
            using (SqlDataReader dbReader = Program.initializeSQLCommand("SELECT MAX(ID) FROM dbo.ServicesTable WHERE Service = '" + servName + "'", dbConnection).ExecuteReader())
            {
                while (dbReader.Read())
                {
                    result = Int32.Parse(dbReader[0].ToString());
                }
            }
            dbConnection.Close();

            return result;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private Person client = null;
        private SqlConnection dbConnection = null;
    }
}
