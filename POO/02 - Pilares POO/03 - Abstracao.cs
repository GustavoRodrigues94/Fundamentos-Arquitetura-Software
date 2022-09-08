namespace POO
{
    public abstract class FormaGeometrica
    {
        protected readonly double _base;
        protected readonly double _altura;

        protected FormaGeometrica(double b, double h)
        {
            _base = b;
            _altura = h;
        }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}
