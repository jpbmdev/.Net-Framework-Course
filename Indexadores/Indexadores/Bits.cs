using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    struct Bits : IIndexadorBase
    {
        int bits;

        public Bits(int _initialBit)
        {
            bits = _initialBit;
        }

        //Con esto yo puedeo llamar a la clase con un Clase[], para get y set
        public bool this[int index]
        {
            //Funcion que retorna el valor de un bit especifico de un numero
            get => (bits & (1 << index)) != 0;
            set
            {
                if (value)
                {
                    bits |= (1 << index);
                }
                else
                {
                    bits &= ~(1 << index);
                }
            }
        }

        public override string ToString()
        {
            return (Convert.ToString(bits, 2));
        }
    }
}
