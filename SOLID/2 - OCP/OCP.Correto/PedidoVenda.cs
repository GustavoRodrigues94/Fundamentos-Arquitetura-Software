namespace SOLID._2___OCP.OCP.Correto
{
    public class PedidoVenda : PedidoBase
    {
        public decimal Frete { get; set; }
        public decimal ValorTotalProdutos { get; set; }

        public override decimal CalcularValorTotal()
        {
            ValorTotal = ValorTotalProdutos + Frete;
            return ValorTotal;
        }
    }
}
