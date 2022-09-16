namespace DesignPatterns._02___Structural._2._1___Adapter
{
    internal class TransacaoAdapter : ITransacao
    {
        private readonly ITransacaoGetnet _transacaoGetnet;

        public TransacaoAdapter(ITransacaoGetnet transacaoGetnet)
        {
            _transacaoGetnet = transacaoGetnet;
        }

        public void IniciarTEF()
        {
            _transacaoGetnet.IniciarTEFAtualizarBandeiras("Bem-vindo(a) ao Getnet");
        }

        public void RealizarTransacao()
        {
            _transacaoGetnet.RealizarTransacao();
        }
    }
}
