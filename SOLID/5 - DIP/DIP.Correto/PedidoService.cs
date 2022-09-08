using SOLID._5___DIP.DIP.Correto.Interfaces;

namespace SOLID._5___DIP.DIP.Correto
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public bool AdicionarPedido(Pedido pedido)
        {
            if (pedido.Validar()) return false;

            _pedidoRepository.AdicionarPedido(pedido);

            return true;
        }
    }
}
