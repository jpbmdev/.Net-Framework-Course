using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    interface IInterface<T>
    {
        T dato { get; set; }
    }

    struct EstructuraGenerica<T>
    {
        T dato;
    }

    class ClaseGenerica<T, U>
    {
        T dato;
        U dato2;

        public ClaseGenerica(T _dato)
        {
            dato = _dato;
        }

        public T HacerAlgo(T parametro)
        {
            T dato = parametro;
            return dato;
        }

        public U HacerAlgo(U parametroU)
        {
            U dato2 = parametroU;
            return dato2;
        }
    }
}
