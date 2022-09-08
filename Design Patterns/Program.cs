using DesignPatterns._01___Creational._1._1___Abstract_Factory;

namespace DesignPatterns
{
    public class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Creational Patterns");
                Console.WriteLine("------------------------");
                Console.WriteLine("1 - Abstract Factory");

                var opcao = Console.ReadKey();

                Console.WriteLine("");
                Console.WriteLine("------------------------");
                Console.WriteLine("");

                switch (opcao.KeyChar)
                {
                    case '1':
                        ExecucaoAbstractFactory.Executar();
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}