using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo c = new Circulo();
            Linea l = new Linea();
            Cuadrado cuadro = new Cuadrado();
            //Estos son metodos diferentes
            IFigura f = c;
            f.Dibujar();

            IRenderizador r = c;
            r.Dibujar();

            //CalcularArea(cuadro);

            //FiguraBase fBase = new FiguraBase();

        }

        static void CalcularArea(IFigura figura)
        {
            if(figura is Circulo)
            {
                figura.Calcular(2, 2);
            }else if(figura is Linea)
            {
                figura.Dibujar();
            }
        }
    }
}
