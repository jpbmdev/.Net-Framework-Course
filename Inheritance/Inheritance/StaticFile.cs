using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class StaticFile : MultimediaFile
    {
           /*
        public StaticFile(
            string _name,
            string _fechaCreacion,
            string _fechaModificacion,
            string _tipoElemento,
            int _tamaño
            ): base(_name, _fechaCreacion, _fechaModificacion, _tipoElemento, _tamaño)
        {

        }
        */

        public void Editar()
        {
            Console.WriteLine("Editando");
        }
    }
}
