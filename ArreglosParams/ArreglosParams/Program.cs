using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int result = Sumar(1,2,3,4,5);
            Console.WriteLine(result);
            Console.ReadLine();
            */

            Persona pers = new Persona();
            pers.ID = 123456;
            pers.Nombre = "Jhon";

            object[] multi = new object[2];

            multi[0] = 2021;
            multi[1] = "2022";
            //multi[2] = 2.34f;
            //multi[3] = pers;

            foreach (var item in multi)
            {
                Console.WriteLine(item);
            }
            int result = Sumar(multi);
            Console.WriteLine(result);
       

            Console.ReadLine();
        }

        private static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        private static int Sumar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2;
        }

        private static int Sumar(params object[] numeros)
        {
            int suma = 0;
            foreach(var numero in numeros)
            {
                if(numero is int)
                {
                    suma += (int) numero;
                }
                else if(numero is string)
                {
                    bool esValido = int.TryParse((string)numero, out int temp);
                    if (esValido)
                    {
                        suma += temp;
                    }
                    else
                    {
                        throw new ArgumentException("Valor no numerico.");
                    }
                }
                else
                {
                    throw new ArgumentException("Valor no numerico.");
                }
            }
            return suma;
        }

        private static int Sumar1(params int[] numeros)
        {
           if(numeros.Length < 2 || numeros == null)
            {
                throw new ArgumentException("El arreglo debe tener dos numeros minimo");
            }
            else
            {
                int suma = 0;
                foreach(var numero in numeros)
                {
                    suma += numero;
                }
                return suma;

            }
        }
    }
}
