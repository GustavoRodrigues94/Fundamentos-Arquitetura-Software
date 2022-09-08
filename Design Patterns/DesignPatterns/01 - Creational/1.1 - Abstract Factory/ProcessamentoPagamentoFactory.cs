namespace DesignPatterns._01___Creational._1._1___Abstract_Factory
{
    public abstract class ProcessamentoPagamentoFactory
    {
        public abstract Pagamento CriarPagamento(decimal valor, IntegradorTEF integrador);
    }
}
