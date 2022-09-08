namespace SOLID._2___OCP.OCP.Violacao
{
    // Nesse caso, quando surgir novos tipos de pedidos, essa classe terá que ser modificada
    // Correndo o risco de quebrar o que já funcionava, e assim ferindo o OCP
    public class PedidoService
    {
        public void CalcularValorTotal(decimal valorPedido, decimal frete, TipoPedidoEnum tipoPedido)
        {
            if (tipoPedido == TipoPedidoEnum.Venda)
            {
                // Calcular valor total levando em consideração o frete
            }

            if (tipoPedido == TipoPedidoEnum.Orcamento)
            {
                // Calcular valor total com desconto, sem levar em consideração o frete
            } 
        }
    }
}
