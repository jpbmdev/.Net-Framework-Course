using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudentPackage;

namespace UseExternalPackage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 12;
            Circulo circulo = new Circulo(valor);
            Console.WriteLine(circulo.CalcularArea());

            Console.ReadLine();
        }
    }
}
