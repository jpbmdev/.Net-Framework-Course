using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hola");
            LimpiarPantalla();

            Console.WriteLine("Hola 2");
            LimpiarPantalla();

            Console.WriteLine("Hola 3");
            LimpiarPantalla();
            */

            /*
            Console.Write("Cual es tu nombre: ");
            string minombre = Console.ReadLine();
            Saludar(minombre);
            */

            int resultado = Sumar(10, 8);
            Console.WriteLine(resultado);

            Console.ReadLine();
        }

        static void LimpiarPantalla()
        {
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }

        static void Saludar(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }

        static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }


        //Methods in callback way
        static void Saludar2() => Console.WriteLine("Hola JP");

        static int Suma2(int numero1, int numero2) => numero1 + numero2;
    }
}
