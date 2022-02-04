using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            p.Print();

            Triangulo t = new Triangulo{ Lado1 = 10, Lado2 = 11, Lado3 = 13 };

            Triangulo tt = new Triangulo ("COLOR"){ Lado1 = 10, Lado2 = 11, Lado3 = 13 };

            Console.ReadLine();
        }
    }
}
