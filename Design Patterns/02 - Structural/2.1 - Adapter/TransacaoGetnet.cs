namespace DesignPatterns._02___Structural._2._1___Adapter
{
    public class TransacaoGetnet : ITransacaoGetnet
    {
        public void IniciarTEFAtualizarBandeiras(string mensagemVisor)
        {
            Console.WriteLine(mensagemVisor);
        }

        public void RealizarTransacao()
        {
            Console.WriteLine("Transação Getnet realizada");
        }
    }
}
