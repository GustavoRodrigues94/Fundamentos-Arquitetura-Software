namespace SOLID._1___SRP.SRP.Correto
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }

        public bool Validar()
        {
            return ValorTotal is > 0 && EmailCliente.Contains('@');
        }
    }
}
