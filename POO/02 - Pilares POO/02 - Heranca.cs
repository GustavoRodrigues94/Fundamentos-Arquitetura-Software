using System;

namespace POO
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario
            {
                Nome = "Gustavo Rodrigues",
                Peso = 76.54,
                Altura = 1.72,
                DataAdmissao = DateTime.Today,
                Salario = new decimal(1273.24)
            };

            funcionario.CalcularIMC();
        }
    }
}
