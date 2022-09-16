using DesignPatterns._01___Creational._1._1___Abstract_Factory;
using DesignPatterns._01___Creational._1._2___Factory_Method;
using DesignPatterns._01___Creational._1._3___Singleton;
using DesignPatterns._02___Structural._2._1___Adapter;

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
                Console.WriteLine("2 - Factory Method");
                Console.WriteLine("3 - Singleton");
                Console.WriteLine("");
                Console.WriteLine("------------------------");
                Console.WriteLine("Structural Patterns");
                Console.WriteLine("------------------------");
                Console.WriteLine("4 - Adapter");

                var opcao = Console.ReadKey();

                Console.WriteLine("");
                Console.WriteLine("------------------------");
                Console.WriteLine("");

                switch (opcao.KeyChar)
                {
                    case '1':
                        ExecucaoAbstractFactory.Executar();
                        break;
                    case '2':
                        ExecucaoFactoryMethod.Executar();
                        break;
                    case '3':
                        ExecucaoSingleton.Executar();
                        break;
                    case '4':
                        ExecucaoAdapter.Executar();
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}