using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    internal class Linea : IFigura
    {
        public int Calcular(int x, int y)
        {
            throw new NotImplementedException();
        }

        public double CalcularArea()
        {
            throw new NotImplementedException();
        }

        public void Dibujar()
        {
            Console.WriteLine("Dibujar una linea");
        }
    }
}
