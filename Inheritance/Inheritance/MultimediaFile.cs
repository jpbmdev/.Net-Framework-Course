using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class MultimediaFile
    {
        public string name;
        public string fechaCreacion;
        public string fechaModificacion;
        public string tipoElemento;
        public int tamaño;

        public string location { get; set; }

        /*
        public MultimediaFile()
        {
            name = "nothing";
            fechaCreacion = "N/A";
            fechaModificacion = "N/A";
            tipoElemento = "N/A";
            tamaño = 0;
        }

        public MultimediaFile(
            string _name,
            string _fechaCreacion,
            string _fechaModificacion,
            string _tipoElemento,
            int _tamaño
            )
        {
            name = _name;
            fechaCreacion = _fechaCreacion;
            fechaModificacion = _fechaModificacion;
            tipoElemento = _tipoElemento;
            tamaño = _tamaño;
        }
        */


        public virtual void  DesplegarInformacion()
        {
            string informacion = name + " " +
                                 fechaCreacion + " " +
                                 fechaModificacion + " " +
                                 tipoElemento + " " +
                                 tamaño.ToString();
            Console.WriteLine("Informacion: {0}", informacion);

        }
    }
}