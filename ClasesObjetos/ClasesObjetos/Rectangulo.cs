namespace ClasesObjetos
{
    // ** Pilares POO **
    // Encapsulamiento
    // Abstraccion
    // Herencia
    // Polimorfismo

    //DEFINICION
    //Nombre: Rectangulo
    //Propiedades:
    //- altura (double)
    //- base (double)
    //- color (string)
    //Metodos:
    //* Calcular el perimetro
    //* Calcular el area

    //Si no le pongo el access a las variables son private por defecto
    //Los nombre de las variables privadas deben inicar con _

    class Rectangulo
    {
        double _alturaRectangulo;
        double _baseRectangulo;
        string _color;

        public Rectangulo()
        {
            _alturaRectangulo = 5;
            _baseRectangulo = 5;
        }
        public Rectangulo(double baseRectInicial, double alturaRectInical)
        {
            _baseRectangulo = baseRectInicial; 
            _alturaRectangulo = alturaRectInical;
        }

        public void Deconstruct(out double baseRect, out double alturaRect) {
            baseRect = _alturaRectangulo;
            alturaRect = _baseRectangulo;
        }

        public double CalcularArea()
        {
            //A = b * h
            return _baseRectangulo * _alturaRectangulo;
        }

        public double CalcularPerimetro()
        {
            // P = 2 * b + 2 * b
            return (2 * _baseRectangulo) + (2 * _alturaRectangulo);
        }

        public static double CalcularPerimetro(int num1, int num2)
        {
            // P = 2 * b + 2 * b
            return (2 * num1) + (2 * num2);
        }
    }
}
