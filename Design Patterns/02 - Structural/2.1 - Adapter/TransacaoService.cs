namespace DesignPatterns._02___Structural._2._1___Adapter
{
    public class TransacaoService
    {
        private readonly ITransacao _transacao;

        public TransacaoService(ITransacao transacao)
        {
            _transacao = transacao;
        }

        public void IniciarTEF()
        {
            _transacao.IniciarTEF();
        }

        public void RealizarTransacao()
        {
            _transacao.RealizarTransacao();
        }
    }
}
