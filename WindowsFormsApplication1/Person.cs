namespace PaymentProcessingProject
{
    class Person
    /*
     * Этот класс описывает клиента: содержит уникальный ID, логин, Имя и Фамилию клиента
     */
    {
        public Person(int clientID, string clientLogin, string clientFirstName, string clientSecondName)
        {
            id = clientID;
            login = clientLogin;
            firstName = clientFirstName;
            secondName = clientSecondName;
        }

        public int getID()
        {
            return id;
        }

        public string getLogin()
        {
            return login;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getSecondName()
        {
            return secondName;
        }

        private int id;
        private string login;
        private string firstName;
        private string secondName;
    }
}
