using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    interface IFigura: ICalculador
    {
        int Calcular(int x, int y);

        void Dibujar();
    }
}
