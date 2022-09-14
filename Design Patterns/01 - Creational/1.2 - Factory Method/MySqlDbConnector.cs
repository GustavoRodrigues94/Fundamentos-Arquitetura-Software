﻿namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public class MySqlDbConnector : DbConnector
    {
        public MySqlDbConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco de dados MySql");
            var connection = new Connection(ConnectionString);
            connection.OpenConnection();

            return connection;
        }
    }
}
