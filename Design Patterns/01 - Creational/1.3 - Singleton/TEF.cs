namespace DesignPatterns._01___Creational._1._3___Singleton
{
    public sealed class TEF
    {
        private static readonly TEF Instance = new TEF();

        private TEF()
        {
            ConfigureTEF();
        }

        private void ConfigureTEF()
        {
            Estabelecimento = "Porecatu Supermercado";
            MensagemVisor = "Bem-vindo(a) ao Porecatu";
            CNPJ = "47.565.623/0001-75";
        }

        private string Estabelecimento { get; set; }
        private string MensagemVisor { get; set; }
        private string CNPJ { get; set; }

        public static TEF GetTEF()
        {
            return Instance;
        }
    }
}
