using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   
            Rectangulo rectangulo = new Rectangulo(4,5);
            double area = rectangulo.CalcularArea();
            Console.WriteLine(area);

            (var baseRect, var alturaRect) = rectangulo;
            Console.WriteLine(baseRect);
            Console.WriteLine(alturaRect);

            double perimetro2 = Rectangulo.CalcularPerimetro(9, 8);
            Console.WriteLine(perimetro2);
            */

            Circulo circulo1 = new Circulo(3);
            Circulo circulo2 = new Circulo(3);
            Circulo circulo3 = new Circulo(3);

            Console.WriteLine(Circulo.numeroDeCirculos);
            Console.WriteLine(Circulo.PI);

            //Clases Anonima
            var objetoAnonimo = new { nombre = "Pepe", apellido = "Solano", edad = 12 };
            Console.WriteLine(objetoAnonimo);


            Console.ReadLine();
        }
    }
}
