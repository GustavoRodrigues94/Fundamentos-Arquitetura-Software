namespace POO
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }

        public double CalcularIMC() => Peso / (Altura * 2);

        public void AlterarPeso(double novoPeso) => Peso = novoPeso;
    }
}
