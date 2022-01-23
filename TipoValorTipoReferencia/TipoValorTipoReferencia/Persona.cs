using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoValorTipoReferencia
{
    internal class Persona : Object
    {
        private string _nombre;
        private int _edad; 

        public Persona(string parNombre, int parEdad)
        {
            _nombre = parNombre;
            _edad = parEdad;
        }
    }
}
