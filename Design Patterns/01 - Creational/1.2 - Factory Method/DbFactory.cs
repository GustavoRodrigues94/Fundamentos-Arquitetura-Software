namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public abstract class DbFactory
    {
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory DataBase(DataBaseEnum dataBase)
        {
            return dataBase switch
            {
                DataBaseEnum.SqlServer => new SqlFactory(),
                DataBaseEnum.MySql => new MySqlFactory(),
                _ => throw new ApplicationException("Banco de dados não conhecido")
            };
        }
    }
}
