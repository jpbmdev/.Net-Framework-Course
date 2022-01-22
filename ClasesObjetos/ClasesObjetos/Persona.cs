using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetos
{
    internal class Persona
    {
        public static int edad;
        
        //En una guachada como esto se ejecuta primero el estatico y despues el publico (se ejecutan los 2)
        public Persona()
        {
            if(edad == 0) edad = 10;
        }

        static Persona()
        {
            if (edad == 0) edad = 40;
        }

        public void EsMayorDeEdad()
        {
            if (edad < 18)
                Console.WriteLine("false");
            else
                Console.WriteLine("true");
        }
    }
}
