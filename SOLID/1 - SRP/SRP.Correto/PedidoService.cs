namespace SOLID._1___SRP.SRP.Correto
{
    //Apenas para representar a ideia do SRP, dá para melhorar mais ainda essa solução (porém, precisaremos dos outros princípios do SOLID)
    public class PedidoService
    {
        public string AdicionarPedido(Pedido pedido)
        {
            if (!pedido.Validar()) return "Ocorreu um erro ao validar";

            var pedidoRepository = new PedidoRepository();
            pedidoRepository.AdicionarPedido(pedido);

            return "Pedido adicionado com sucesso!";
        }
    }
}
