﻿using System.Data.SqlClient;

namespace SOLID._5___DIP.DIP.Violacao
{
    public class PedidoRepository
    {
        public void AdicionarPedido(Pedido pedido)
        {
            using var connection = new SqlConnection();
            var command = new SqlCommand();

            connection.ConnectionString = "ConnectionString";
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.Parameters.AddWithValue("NomeCliente", pedido.NomeCliente);
            command.Parameters.AddWithValue("EmailCliente", pedido.EmailCliente);
            command.Parameters.AddWithValue("DataPedido", pedido.DataPedido);
            command.Parameters.AddWithValue("ValorTotal", pedido.ValorTotal);
            command.CommandText = "INSERT INTO PEDIDO (NomeCliente, EmailCliente, DataPedido, ValorTotal) Values (@NomeCliente, @EmailCliente, @DataPedido, @ValorTotal)";

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
