namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sqlConnection = DbFactory.DataBase(DataBaseEnum.SqlServer)
                .CreateConnector("connectionString")
                .Connect();

            sqlConnection.ExecuteCommand("select * from tabelaSqlServer");
            sqlConnection.CloseConnection();

            Console.WriteLine("");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");

            var mySqlConnection = DbFactory.DataBase(DataBaseEnum.MySql)
                .CreateConnector("connectionString")
                .Connect();

            mySqlConnection.ExecuteCommand("select * from tabelaMySql");
            mySqlConnection.CloseConnection();
        }
    }
}
