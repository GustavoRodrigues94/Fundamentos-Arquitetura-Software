using DesignPatterns._01___Creational._1._1___Abstract_Factory;
using DesignPatterns._01___Creational._1._2___Factory_Method;
using DesignPatterns._01___Creational._1._3___Singleton;

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
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}