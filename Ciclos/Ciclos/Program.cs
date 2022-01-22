using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            bool esCierto = true;
            while (esCierto) {
                Console.WriteLine("Ejecutando");
                esCierto = false;
            }
            */

            /*
            int num = 0;
            while (num <= 10)
            {
                Console.WriteLine("Numero: " + num++);
            }
            */

            /*
            string input = string.Empty; 

            while (input != "Hola")
            {
                Console.WriteLine("Ejecutando");
                input = Console.ReadLine();
            }
            */

            /*
            int suma = 0;
            for (int i=1; i<=10; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);
            */

            int i = 0;
            int suma = 0;
            do
            {
                suma += i;
                i++;
            } while (i <= 10);

            Console.ReadLine();
        }
    }
}
