using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoValorTipoReferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            int value = 0;
            AgregarUno(value);
            Console.WriteLine(value);
            */

            /*
            Circulo circ = new Circulo(20);

            Console.WriteLine(circ.radio);
            AgregarUno(circ);
            Console.WriteLine(circ.radio);

            double area = circ.CalcularArea();
            Console.WriteLine(area);

            if (circ is IDisposable) circ.Dispose();
            */

            /*
            Circulo circ = new Circulo(9);

            if (circ == null)
            {
                circ = new Circulo(12);
                circ.radio = 20;
            }
            */

            //null condicional

            /*
            Console.WriteLine(circ?.radio);
            */

            //Tipo Nullable

            /*
            //int i = null; esto peta, esto se usa cuando se llama algo de la bd y puede ser null
            int? i = null;

            int? j = 0;

            j = i;

            if (i == null)
                i = 20;
            else
                Console.WriteLine(i);
            */

            //Parametros utilizando ref

            /*
            int mivalor = 50;
            AgregarUno(ref mivalor);
            Console.WriteLine(mivalor);
            */

            //Parametros utilizando out

            /*
            int.TryParse("lol", out int pruebaConversion);
            Console.WriteLine(pruebaConversion);
            */

            // Clase System.Object

            int i = 0;

            object entero = 12;

            object cadena = "hola";

            object circulo = new Circulo(2);

            Circulo circulo1 = new Circulo(2);

            Console.ReadLine();
        }

        public static void AgregarUno(int param)
        {
            param++;
        }
        public static void AgregarUno(ref int param)
        {
            param++;
        }
        public static void AgregarUno(Circulo circulo)
        {
            circulo.radio++;
        }
    }
}
