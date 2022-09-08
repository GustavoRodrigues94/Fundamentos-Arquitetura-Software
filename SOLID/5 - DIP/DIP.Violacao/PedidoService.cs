namespace SOLID._5___DIP.DIP.Violacao
{
    public class PedidoService
    {
        public string AdicionarPedido(Pedido pedido)
        {
            if (!pedido.Validar()) return "Ocorreu um erro ao validar";

            // Acoplamento/Violação pois está dependendo de uma implementação e não de uma abstração (interface)
            var pedidoRepository = new PedidoRepository();
            pedidoRepository.AdicionarPedido(pedido);

            return "Pedido adicionado com sucesso!";
        }
    }
}
