namespace DesignPatterns._01___Creational._1._1___Abstract_Factory
{
    public class ProcessamentoPagamentoSitefFactory : ProcessamentoPagamentoFactory
    {
        public override Pagamento CriarPagamento(decimal valor, IntegradorTEF integrador)
        {
            return PagamentoCreator.Criar(valor, integrador);
        }
    }
}
