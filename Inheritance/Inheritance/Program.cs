using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultimediaFile mfile = new MultimediaFile();

            DinamicFile dfile = new DinamicFile();

            StaticFile sfile = new StaticFile();

            MultimediaFile multimedia = dfile;

            dfile.DesplegarInformacion();

            string oracion = "Haciendo un test weas";
            oracion.ContadorPalabras();

            Console.ReadLine();
        }
    }
}
