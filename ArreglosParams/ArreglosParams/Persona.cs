using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosParams
{
    internal class Persona
    {
        public int ID { get; set; }

        public string Nombre { get; set; }


        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
