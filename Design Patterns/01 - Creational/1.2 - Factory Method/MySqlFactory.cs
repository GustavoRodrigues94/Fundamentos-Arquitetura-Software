namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public class MySqlFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
            return new MySqlDbConnector(connectionString);
        }
    }
}
