using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 7;
            int numero2 = 15;

            int resultado = numero1 + numero2;

            Console.WriteLine(resultado);

            Console.WriteLine(2 - 5);

            Console.WriteLine(numero1 - numero2);

            int numero3 = 12;
            double numero4 = 8.5;

            Console.WriteLine(numero3 + numero4); //No es buena practica operar distinos tipos de numeros

            Console.WriteLine("Hola" + "Mundo");

            Console.WriteLine('a' + 'a');

            Console.WriteLine("a" + "a");

            Console.WriteLine(8 / 4);

            Console.WriteLine(8.0 / 4.0);

            Console.WriteLine(10.0 / 3.0);

            Console.WriteLine(10.0 / 3); // Mala practica

            Console.WriteLine(2 + 3 * 5); //17

            Console.WriteLine((2 + 3) * 5); // 25

            Console.WriteLine("--------------------------------------");

            //Modulo

            Console.WriteLine(5380 % 30);

            Console.WriteLine(546 / 31); 

            Console.WriteLine("--------------------------------------");

            //Numeros infinitos y NaN Not a Number

            double infinito1 = 5.0 / 0.0;

            Console.WriteLine(infinito1);

            double infinito2 = 0.0 / 0.0;

            Console.WriteLine(infinito2);

            Console.WriteLine("--------------------------------------");

            //Incremento y decremento

            int conteo = 0;
            Console.WriteLine(conteo); //0

            conteo += 1;
            Console.WriteLine(conteo); //1

            //Prefijo
            ++conteo;
            Console.WriteLine(conteo); //2

            conteo -= 1;
            Console.WriteLine(conteo); //1

            //Postfijo
            --conteo;
            Console.WriteLine(conteo); //0

            int conteo2 = 10;

            Console.WriteLine(conteo2++);
            Console.WriteLine(conteo2);
            Console.WriteLine(--conteo2);


            Console.ReadLine();
        }
    }
}
