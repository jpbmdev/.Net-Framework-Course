using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    internal class Circulo : FiguraBase, IFigura, IRenderizador
    {
        int radio;
        public int Calcular(int x, int y)
        {
            return x * y;
        }

        public double CalcularArea()
        {
            throw new NotImplementedException();
        }

        void IFigura.Dibujar()
        {
            Console.WriteLine("Dibujar una circulo");
        }

        void IRenderizador.Dibujar()
        {
            throw new NotImplementedException();
        }

        public void Renderizar()
        {
            throw new NotImplementedException();

        }

        public override void ObtenerTop()
        {
            throw new NotImplementedException();
        }
    }
}
