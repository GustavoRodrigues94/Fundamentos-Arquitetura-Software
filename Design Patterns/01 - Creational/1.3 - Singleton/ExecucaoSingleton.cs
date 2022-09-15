namespace DesignPatterns._01___Creational._1._3___Singleton
{
    public class ExecucaoSingleton
    {
        public static void Executar()
        {
            var tef1 = TEF.GetTEF();
            var tef2 = TEF.GetTEF();
            var tef3 = TEF.GetTEF();
            var tef4 = TEF.GetTEF();

            if (tef1 == tef2 && tef2 == tef3 && tef3 == tef4)
                Console.WriteLine("Mesma instância de TEF");
        }
    }
}
