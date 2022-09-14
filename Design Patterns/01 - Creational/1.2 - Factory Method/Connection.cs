namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public class Connection
    {
        private string ConnectionString { get; set; }
        private bool Opened { get; set; } 

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine($"Executando comando: {command}");
        }

        public void OpenConnection()
        {
            Console.WriteLine("Conexão aberta");
            Opened = true;
        }

        public void CloseConnection()
        {
            Console.WriteLine("Conexão fechada");
            Opened = false;
        }
    }
}
