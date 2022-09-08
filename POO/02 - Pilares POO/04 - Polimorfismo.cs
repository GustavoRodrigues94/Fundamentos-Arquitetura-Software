namespace POO
{
    public class Quadrado : FormaGeometrica
    {
        public Quadrado(double b, double h) : base(b, h) { }

        public override double CalcularArea()
        {
            return _base * _altura;
        }

        public override double CalcularPerimetro()
        {
            return _altura * 4;
        }
    }
}
