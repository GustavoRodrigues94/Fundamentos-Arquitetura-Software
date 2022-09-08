using System.Data.SqlClient;

namespace SOLID._1___SRP.SRP.Violacao
{
    //Classe ferindo o SRP, pois sua responsabilidade está muito além de ser uma entidade Pedido com regras de domínio.
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string NomeCliente { get; set; }

        public string EmailCliente { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }

        public string AdicionarPedido()
        {
            if (!EmailCliente.Contains('@'))
                return "Email incorreto";

            using var connection = new SqlConnection();
            var command = new SqlCommand();

            connection.ConnectionString = "ConnectionString";
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.Parameters.AddWithValue("NomeCliente", NomeCliente);
            command.Parameters.AddWithValue("EmailCliente", EmailCliente);
            command.Parameters.AddWithValue("DataPedido", DataPedido);
            command.Parameters.AddWithValue("ValorTotal", ValorTotal);
            command.CommandText = "INSERT INTO PEDIDO (NomeCliente, EmailCliente, DataPedido, ValorTotal) Values (@NomeCliente, @EmailCliente, @DataPedido, @ValorTotal)";

            connection.Open();
            command.ExecuteNonQuery();

            return "Pedido cadastrado com sucesso!";
        }
    }
}
