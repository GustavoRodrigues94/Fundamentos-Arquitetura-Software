namespace SOLID._2___OCP.OCP.Correto
{
    public class PedidoOrcamento : PedidoBase
    {
        public decimal Desconto { get; set; }
        public decimal ValorTotalProdutos { get; set; }

        public override decimal CalcularValorTotal()
        {
            ValorTotal = ValorTotalProdutos - Desconto;
            return ValorTotal;
        }
    }
}
