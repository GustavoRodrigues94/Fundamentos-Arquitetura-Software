namespace DesignPatterns._02___Structural._2._1___Adapter
{
    public class ExecucaoAdapter
    {
        public static void Executar()
        {
            var transacaoPadrao = new TransacaoService(new Transacao());
            transacaoPadrao.IniciarTEF();
            transacaoPadrao.RealizarTransacao();

            var transacaoGetnet = new TransacaoService(new TransacaoAdapter(new TransacaoGetnet()));
            transacaoGetnet.IniciarTEF();
            transacaoGetnet.RealizarTransacao();
        }
    }
}
