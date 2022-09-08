namespace DesignPatterns._01___Creational._1._1___Abstract_Factory
{
    public abstract class Pagamento
    {
        protected Pagamento(decimal valor, IntegradorTEF integrador)
        {
            Valor = valor;
            IntegradorTEF = integrador;
        }

        public decimal Valor { get; set; }
        public IntegradorTEF IntegradorTEF { get; set; }

        public abstract void ProcessarPagamento();
    }

    public enum IntegradorTEF
    {
        Sitef,
        Getnet
    }

    public class PagamentoSitef : Pagamento
    {
        public PagamentoSitef(decimal valor, IntegradorTEF integrador) : base(valor, integrador)
        {
        }

        public override void ProcessarPagamento()
        {
            Console.WriteLine("Pagamento processado via Sitef");
        }
    }

    public class PagamentoGetnet : Pagamento
    {
        public PagamentoGetnet(decimal valor, IntegradorTEF integrador) : base(valor, integrador)
        {
        }

        public override void ProcessarPagamento()
        {
            Console.WriteLine("Pagamento processado via Getnet");
        }
    }

    public class PagamentoCreator
    {
        public static Pagamento Criar(decimal valor, IntegradorTEF integrador)
        {
            switch (integrador)
            {
                case IntegradorTEF.Sitef: 
                    return new PagamentoSitef(valor, integrador);
                case IntegradorTEF.Getnet:
                    return new PagamentoGetnet(valor, integrador);
                default:
                    throw new ApplicationException("Integrador desconhecido.");
            }
        }
    }
}
