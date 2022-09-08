namespace POO
{

    #region Caso 1

    // Herança
    // Ao começar ter muitas adaptações na classe pai, é um sinal que não deve ser usado a herança
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }

    // Composição
    public class PessoaFisica2
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }

    public class TesteHerancaComposicao
    {
        public TesteHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica
            {
                Nome = "João",
                Altura = 1.84,
                Cpf = "21075365000155",
                Peso = 85.45
            };

            var pessoaComposicao = new PessoaFisica2
            {
                Pessoa = new Pessoa
                {
                    Nome = "João",
                    Altura = 1.84,
                    Peso = 85.45
                },
                Cpf = "21075365000155"
            };

            var nomeHeranca = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
        }
    }

    #endregion

    #region Caso 2

    public interface IRepositorio<T>
    {
        void Adicionar(T objeto);

        void Excluir(T objeto);
    }

    public interface IRepositorioPessoa
    {
        void Adicionar(Pessoa pessoa);
    }

    public class RepositorioGenerico<T> : IRepositorio<T>
    {
        public void Adicionar(T objeto)
        {
            
        }

        public void Excluir(T objeto)
        {
            
        }
    }

    // Forte acoplamento, pois está sendo abstraído uma classe e pode forçar comportamentos que você não deseja
    public class RepositorioHerancaPessoa : RepositorioGenerico<Pessoa>, IRepositorioPessoa
    {

    }

    // Baixo acoplamento, pois está abstraindo uma interface e você só irá expor métodos que deseja
    public class RepositorioComposicaoPessoa : IRepositorioPessoa
    {
        private readonly IRepositorio<Pessoa> _repositorioPessoa;

        public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)
        {
            _repositorioPessoa = repositorioPessoa;
        }

        public void Adicionar(Pessoa pessoa)
        {
            _repositorioPessoa.Adicionar(pessoa);
        }
    }

    public class TestesHerancaComposicao2
    {
        public TestesHerancaComposicao2()
        {
            var repoHeranca = new RepositorioHerancaPessoa();
            repoHeranca.Adicionar(new Pessoa());
            repoHeranca.Excluir(new Pessoa());

            var repoComposicao = new RepositorioComposicaoPessoa(new RepositorioGenerico<Pessoa>());
            repoComposicao.Adicionar(new Pessoa());
        }
    }

    #endregion

}
