using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    static class MetodosExension
    {
        public static int ContadorPalabras(this string cadena)
        {
            var palabras = cadena.Split(' ');
            return palabras.Length;
        }

    }
}