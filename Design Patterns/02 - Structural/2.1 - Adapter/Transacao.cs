namespace DesignPatterns._02___Structural._2._1___Adapter
{
    public class Transacao : ITransacao
    {
        public void IniciarTEF()
        {
            Console.WriteLine("TEF padrão iniciado");
        }

        public void RealizarTransacao()
        {
            Console.WriteLine("Transação padrão realizada");
        }
    }
}
