namespace PaymentProcessingProject
{
    class Payment
    /*
     * Класс описывает заявку на оплату, вносимую в базу данных. Содержит уникальный ID заявки, ID клиента, 
     * ID услуги, которая оплачивается данной заявкой и сумму платежа
     */
    {
        public Payment(int payID, int clientID, int serviceID, double amount) 
        {
            id = payID;
            clID = clientID;
            servID = serviceID;
            amt = amount;
        }

        public int getID()
        {
            return id;
        }

        public int getClientID()
        {
            return clID;
        }

        public int getServiceID()
        {
            return servID;
        }

        public double getAmount()
        {
            return amt;
        }

        private int id;
        private int clID;
        private int servID;
        private double amt;
    }
}
