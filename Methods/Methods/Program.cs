using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static int Iva = 19;

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hola");
            LimpiarPantalla();
            */

            /*
            Console.Write("Cual es tu nombre: ");
            string minombre = Console.ReadLine();
            Saludar(minombre);
            */

            /*
            int resultado = Sumar(10, 8);
            Console.WriteLine(resultado);
            */

            /*
            int numero1 = 0;
            int numero2 = 0;
            (numero1, numero2) = Return2Numbers(8, 9);
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            */

            /*
            (int edad, string nombre) datos = Return2DiferentValues(22, "JP");
            Console.WriteLine(datos.nombre);
            Console.WriteLine(datos.edad);
            */

            /*
            (int cociente, int residuo) datos = Divide2Numbers(50, 22);
            Console.WriteLine(datos.cociente);
            Console.WriteLine(datos.residuo);
            */

            /*
            (int numero, int miIva) = Return2NumbersGlobal(5);
            Console.WriteLine(numero);
            Console.WriteLine(miIva);
            */

            /*
            double resultado = CalcularCuenta2(20, 2, 2, 2);
            Console.WriteLine(resultado);
            */

            /*
            //var resultado = ObtenerEmpleado();
            Tuple<int, string, string> resultado = ObtenerEmpleado();
            Console.WriteLine(resultado);
            */

            EsribirTextoAnidado("Hola");

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

        //Return multiple values
        static (int, int) Return2Numbers(int numero1, int numero2)
        {
            return (numero1, numero2);
        }

        static (int, string) Return2DiferentValues(int edad, string nombre)
        {
            return (edad, nombre);
        }

        static (int, int) Divide2Numbers(int numero1, int numero2)
        {
            int cocientee = numero1 / numero2;
            int reciduo = numero1 % numero2;
            return (cocientee, reciduo);
        }

        static (int, int) Return2NumbersGlobal(int numero1)
        {
            return (numero1, Iva);
        }

        //Overloading de metodos

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeoro1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        static int Multiplicar(int numeoro1, int numero2)
        {
            return numero2 * numeoro1;
        }

        static double Multiplicar(double numeoro1, double numero2)
        {
            return numero2 * numeoro1;
        }

        static double CalcularCuenta(double totalCuenta, double propina, double comensales)
        {
            return (totalCuenta + propina) / comensales;
        }

        static double CalcularCuenta(double totalCuenta, double propina, double comensales, double estacionamiento)
        {
            return (totalCuenta + propina + estacionamiento) / comensales;
        }

        static double CalcularCuenta2(double totalCuenta, double propina, double comensales = 1, double estacionamiento = 0)
        {
            return (totalCuenta + propina + estacionamiento) / comensales;
        }

        // Tuplas

        static Tuple<int, string, string> ObtenerEmpleado()
        {
            int id = 123;
            string nombre = "Carlos";
            string apellido = "Perez";
            return Tuple.Create(id, nombre, apellido);
        }

        //Metodo Obsoleto

        [Obsolete("Este metodo esta deprecado o obsoleto")]
        static int MultiplicarObsoleto(int numeoro1, int numero2)
        {
            return numero2 * numeoro1;
        }
        
        //Metodo anidados
         static void EsribirTextoAnidado(string texto)
        {
            Console.WriteLine(texto);
            LimpiarPantallaAnidada();
            void LimpiarPantallaAnidada()
            {
                Console.ReadLine();
                Console.Clear();
                Console.Beep();
            }
        }


    }
}
