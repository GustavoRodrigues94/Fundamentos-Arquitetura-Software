namespace POO
{

    //Definição de classe
    public class Carro
    {
        public string Marca { get; set; }
        public short Ano { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
    }

    public class Objeto
    {
        //Definição de objeto
        public Objeto()
        {
            var carro = new Carro
            {
                Marca = "Ford",
                Ano = 2022,
                Modelo = "Ford KA",
                Cor = "Preto"
            };
        }
    }
}
