using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{

    class FiguraDerivadaDeNuevo : FiguraDerivada
    {

    }

    class FiguraDerivada : FiguraBase
    {
        public sealed override void ObtenerTop()
        {
            throw new NotImplementedException();
        }
    }

    abstract class FiguraBase
    {
        protected string colorFigura;

        public void ObtenerUbicacion()
        {
            Console.WriteLine("X,Y");
        }

        public abstract void ObtenerTop();
    }
}
