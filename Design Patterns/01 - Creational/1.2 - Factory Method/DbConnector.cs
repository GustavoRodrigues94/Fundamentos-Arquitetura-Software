namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public abstract class DbConnector
    {
        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected string ConnectionString { get; set; }
        public abstract Connection Connect();
    }
}
