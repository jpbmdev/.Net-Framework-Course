using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int entero;
            Circulo circ = new Circulo(20);

            //Array o arreglos
            int[] numeros = new int[5];

            int[] numeros2 = new int[5] { 1, 2, 3, 4, 5 };

            int[] numeros3 = { 1, 2, 3, 4, 5 };

            Circulo[] circulos = new Circulo[5];

            Circulo[] circulos2 = new Circulo[5]
            {
                new Circulo(2),
                new Circulo(2),
                new Circulo(2),
                new Circulo(2),
                new Circulo(2)
            };

            var personas = new[]
            {
                new {Nombre= "Juan"},
                new {Nombre= "Mary"},
            };

            int[] numeros22 = new int[5] { 1, 2, 3, 4, 5 };

            var tipo = numeros.GetType();

            for (int i=0;i<numeros22.Length; i++)
            {
                Console.WriteLine(numeros22[i]);
            }

            foreach(int numero in numeros22)
            {
                Console.WriteLine(numero);
            }

            var valor = Inicializar();
            */

            int[] arreglo = { 1, 2, 4, 5 };
            int[] arreglo2 = arreglo;

            arreglo[0] = 100;
            arreglo[1] = 200;

            Console.WriteLine(arreglo[0]);
            Console.WriteLine(arreglo2[0]);

            //Copiar arreglos sin refrencia
            int[] arrayOrigen = { 1, 2, 4, 5 };
            int[] arrayDestino = (int [])arrayOrigen.Clone();


            Console.WriteLine(arrayOrigen);
            Console.WriteLine(arrayDestino);

            //Arreglos bidimencionales

            int[,] bidimensional = new int[2, 2];

            bidimensional[0, 0] = 1;
            bidimensional[0, 1] = 2;
            bidimensional[1, 0] = 3;
            bidimensional[1, 1] = 4;

            //Obtener dimiensiones de arreglo multidimensional
            Console.WriteLine(bidimensional.GetLength(0));
            Console.WriteLine(bidimensional.GetLength(1));

            Console.ReadLine();
        }

        static int[] Inicializar()
        {
            Console.Write("Numeor de elementos: ");
            string respuesta = Console.ReadLine();
            int cantidad = int.Parse(respuesta);

            int[] numeros = new int[cantidad];

            for (int i=0;i<cantidad; i++)
            {
                Console.Write("Valor para el elemento: ");
                respuesta = Console.ReadLine();
                int dato = int.Parse(respuesta);
                numeros[i] = dato;
            }
            return numeros;
        }
    }
}
