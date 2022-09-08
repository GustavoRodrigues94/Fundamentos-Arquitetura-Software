namespace SOLID._4___ISP.ISP.Correto.Interfaces
{
    public interface IPedidoRepository
    {
        void AdicionarPedido();
        void AtualizarPedido();
        void DeletarPedido();
        void ObterPedidoPaginado();
    }
}
