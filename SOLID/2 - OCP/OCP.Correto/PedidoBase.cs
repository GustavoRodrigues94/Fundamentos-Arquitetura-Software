namespace SOLID._2___OCP.OCP.Correto
{
    public abstract class PedidoBase
    {
        public decimal ValorTotal { get; set; }
        public abstract decimal CalcularValorTotal();
    }
}
