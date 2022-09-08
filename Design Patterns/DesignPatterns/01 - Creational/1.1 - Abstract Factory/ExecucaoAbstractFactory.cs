namespace DesignPatterns._01___Creational._1._1___Abstract_Factory
{
    public static class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var pagamentos = new List<Pagamento>
            {
                PagamentoCreator.Criar(new decimal(255.69), IntegradorTEF.Sitef),
                PagamentoCreator.Criar(new decimal(956.31), IntegradorTEF.Getnet)
            };

            pagamentos.ForEach(pagamento => ProcessamentoPagamento.CriarProcessamentoPagamento(pagamento).ProcessarPagamento());
        }
    }
}
