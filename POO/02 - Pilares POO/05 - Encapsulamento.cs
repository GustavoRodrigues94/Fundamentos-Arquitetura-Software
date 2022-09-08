namespace POO
{
    public class CalculadoraDados
    {
        public void CalcularDados()
        {
            var quadrado = new Quadrado(15.45, 15.45);
            quadrado.CalcularArea();
            quadrado.CalcularPerimetro();
        }
    }
}
