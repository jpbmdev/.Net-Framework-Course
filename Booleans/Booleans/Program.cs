using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleans
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Expresiones Booleanas
            bool mayorEdad = false;

            //Operador NOT -> !
            mayorEdad = !true; // False

            mayorEdad = !false; // true

            mayorEdad = !mayorEdad;

            //Operadores Relacionales

            //Igualdad ==
            bool esIgual = 42 == 42;

            //Desigualdad !=
            bool noEsIgual = 32 != 23;

            Console.WriteLine(esIgual);

            // < > <= >=

            int edad = 30;

            bool resultado = edad <= 30;

            bool resultado2 = edad >= 30; // false

            //Operadores Logicos

            //AND && 
            //OR ||

            bool logico = (3 == 3) && (4 == 4) && (5 == 5); //true
            bool logico2 = (3 == 2) || (1 == 4) || (5 == 5); //true

            Console.WriteLine(logico);

            if (!(5 == 4) && (1 == 1))
            {
                Console.WriteLine("Si");
            }
            else
            {
                Console.WriteLine("No");
            }

            bool tieneDinero = true;
            int valorTargeta = 0;

            if (tieneDinero)
            {
                Console.WriteLine("RTX 3090TI");
                valorTargeta = 2000000;
            }
            else
            {
                Console.WriteLine("gt 710");
                valorTargeta = 1000;
            }

            int dia = 1;

            if (dia == 1)
            {
                Console.WriteLine("1");
            }
            else if (dia == 2)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("No es 1 o 2");
            }

            switch (dia)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("No es 1 o 2");
                    break;
            }

            //Ternario

            double temperatura = 20.2;

            string resultado4 = (temperatura < 20.0) ? "Frio" : "Caliente";

            Console.ReadLine();
        }
    }
}
