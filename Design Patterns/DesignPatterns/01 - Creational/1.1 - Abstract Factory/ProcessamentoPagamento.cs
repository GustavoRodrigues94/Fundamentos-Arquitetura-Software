namespace DesignPatterns._01___Creational._1._1___Abstract_Factory
{
    public class ProcessamentoPagamento
    {
        private readonly Pagamento _pagamento;

        public ProcessamentoPagamento(ProcessamentoPagamentoFactory factory, Pagamento pagamento)
        {
            _pagamento = factory.CriarPagamento(pagamento.Valor, pagamento.IntegradorTEF);
        }

        public void ProcessarPagamento()
        {
            _pagamento.ProcessarPagamento();
        }

        public static ProcessamentoPagamento CriarProcessamentoPagamento(Pagamento pagamento)
        {
            switch (pagamento.IntegradorTEF)
            {
                case IntegradorTEF.Sitef:
                    return new ProcessamentoPagamento(new ProcessamentoPagamentoSitefFactory(), pagamento);
                case IntegradorTEF.Getnet:
                    return new ProcessamentoPagamento(new ProcessamentoPagamentoGetnetFactory(), pagamento);
                default:
                    throw new ApplicationException("Integrador não identificado.");
            }
        }
    }
}
