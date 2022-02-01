using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class DinamicFile : MultimediaFile
    {
        public int duracion;


        /*
        public DinamicFile(
            string _name,
            string _fechaCreacion,
            string _fechaModificacion,
            string _tipoElemento,
            int _tamaño,
            int _duracion
            ) : base(_name, _fechaCreacion, _fechaModificacion, _tipoElemento, _tamaño)
        {
            duracion = _duracion;
        }
        */

        public override void DesplegarInformacion()
        {
            Console.WriteLine("Desplegar Informacion Dinamic");
        }

        public void Detener()
        {
            Console.WriteLine("Deteniendo..");
        }

        public void Pausar()
        {
            Console.WriteLine("Pausando");
        }

        public void Reproducir()
        {
            Console.WriteLine("Reproduciendo");
        }
    }
}
